using System;
using System.IO.Ports;
using System.Threading;
using Diagnostics = System.Diagnostics;

namespace Terrarium
{
    public class DataStreamEventArgs : EventArgs
    {
        #region Defines
        private byte[] _bytes;
        #endregion

        #region Constructors
        public DataStreamEventArgs(byte[] bytes)
        {
            _bytes = bytes;
        }
        #endregion

        #region Properties
        public byte[] Response
        {
            get { return _bytes; }
        }
        #endregion
    }

    public class SerialClient : IDisposable
    {
        #region Defines
        private string _portName;
        private int _portBaudRate;
        private int _portDataBits;
        private Parity _portParity;
        private StopBits _portStopBits;
        private Handshake _portHandshake;
        private SerialPort _serialPort;
        private Thread serThread;
        private DateTime _lastReceive;

        /*The Critical Frequency of Communication to Avoid Any Lag*/
        private const int freqCriticalLimit = 20;
        #endregion

        #region Constructors

        public SerialClient(string portName, int portBaudRate, int portDataBits, Parity portParity, StopBits portStopBits, Handshake portHandshake)
        {
            _portName = portName;
            _portBaudRate = portBaudRate;
            _portDataBits = portDataBits;
            _portParity = portParity;
            _portStopBits = portStopBits;
            _portHandshake = portHandshake;
            _lastReceive = DateTime.MinValue;

            if (_serialPort == null)
            {
                _serialPort = new SerialPort(_portName, _portBaudRate, _portParity, _portDataBits, _portStopBits);

            }
        }
        #endregion

        #region Custom Events
        public event EventHandler<DataStreamEventArgs> OnReceiving;

        #endregion

        #region Properties
        public string PortName
        {
            get { return _portName; }
        }
        public int BaudRate
        {
            get { return _portBaudRate; }
        }
        public int DataBits
        {
            get { return _portDataBits; }
        }
        public Parity Parity
        {
            get { return _portParity; }
        }
        public StopBits StopBits
        {
            get { return _portStopBits; }
        }
        public Handshake Handshake
        {
            get { return _portHandshake; }
        }

        public string ConnectionString
        {
            get
            {
                return String.Format("[Serial] PortName: {0} | Baudrate: {1}",
                    _serialPort.PortName, _serialPort.BaudRate.ToString());
            }
        }
        #endregion

        #region Methods
        #region Port Control

        public bool Open()
        {
            try
            {
                _serialPort = new SerialPort(_portName, _portBaudRate, _portParity, _portDataBits, _portStopBits);

                if (_serialPort.IsOpen == false)
                {
                    _serialPort.ReadTimeout = -1;
                    _serialPort.WriteTimeout = -1;

                    _serialPort.Open();

                    if (_serialPort.IsOpen == true)
                    {
                        serThread = new Thread(new ThreadStart(SerialReceiving));
                        serThread.Priority = ThreadPriority.Normal;
                        serThread.Name = "SerialHandle" + serThread.ManagedThreadId;
                        serThread.Start(); /*Start The Communication Thread*/
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public bool IsOpen()
        {
            return _serialPort.IsOpen;
        }

        public void Close()
        {
            if (_serialPort != null && _serialPort.IsOpen)
            {
                serThread.Abort();
                Thread.Sleep(10);
                if (serThread.ThreadState == ThreadState.Aborted)
                {
                    _serialPort.Close();
                    while (_serialPort.IsOpen == true) { }
                }
            }
        }

        public bool ResetPort()
        {
            Close();
            return Open();
        }

        public void SetBaudrate(int BaudRate)
        {
            _serialPort.BaudRate = BaudRate;
        }

        public void SetPortName(string PortName)
        {
            if (_serialPort.IsOpen != true)
            {
                _serialPort.PortName = PortName;
            }
        }

        public void SetDataBits(int DataBits)
        {
            _serialPort.DataBits = DataBits;
        }

        public void SetParity(Parity Parity)
        {
            _serialPort.Parity = Parity;
        }

        public void SetStopBits(StopBits StopBits)
        {
            _serialPort.StopBits = StopBits;
        }

        public void SetHandshake(Handshake Handshake)
        {
            _serialPort.Handshake = Handshake;
        }

        #endregion
        #region Transmit/Receive
        public void Transmit(byte[] packet)
        {
            _serialPort.Write(packet, 0, packet.Length);
        }

        public int Receive(byte[] bytes, int offset, int count)
        {
            int readBytes = 0;

            if (count > 0)
            {
                readBytes = _serialPort.Read(bytes, offset, count);
            }

            return readBytes;
        }

        #endregion
        #region IDisposable Methods
        public void Dispose()
        {
            Close();

            if (_serialPort != null)
            {
                _serialPort.Dispose();
                _serialPort = null;
            }
        }
        #endregion


        private void SerialReceiving()
        {
            while (true)
            {
                int count = 0;
                try
                {
                    count = _serialPort.BytesToRead;
                }
                catch (Exception ex)
                {
                    if (ex is System.IO.IOException || ex is UnauthorizedAccessException)
                    {
                        OnSerialErrorAccure(EventArgs.Empty);
                        serThread.Abort();
                    }
                }       

                /*Get Sleep Inteval*/
                TimeSpan tmpInterval = (DateTime.Now - _lastReceive);

                /*Form The Packet in The Buffer*/
                byte[] buf = new byte[count];
                int readBytes = Receive(buf, 0, count);

                if (readBytes > 0)
                {
                    OnSerialReceiving(buf);
                }
            }
        }


        #region Custom Events Invoke Functions
        private void OnSerialReceiving(byte[] res)
        {
            OnReceiving?.Invoke(this, new DataStreamEventArgs(res));
        }

        public event EventHandler serialError;
        private void OnSerialErrorAccure(EventArgs e)
        {
            serialError?.Invoke(this, e);
        }

        #endregion
    }

}
#endregion