using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terrarium
{
    class SerialCom
    {
        private string portName;
        private int portBaudRate;
        private int portDataBits;
        private Parity portParity;
        private StopBits portStopBits;
        private Handshake portHandshake;
        private SerialPort serialPort;

        public event EventHandler OnSerialError;
        public event EventHandler<DataStreamEventArgs> OnSerialReceiving;

        public SerialCom(string portName)
        {
            if (portName != null)
            {
                serialPort = new SerialPort(portName);                
            }
        }

        public string PortName
        {
            get => portName;
            set
            {
                if (serialPort.IsOpen != true) serialPort.PortName = portName = value;
            }
        }

        public int PortBaudRate { get => portBaudRate; set => serialPort.BaudRate = portBaudRate = value; }
        public int PortDataBits { get => portDataBits; set => serialPort.DataBits = portDataBits = value; }
        public Parity PortParity { get => portParity; set => serialPort.Parity = portParity = value; }
        public StopBits PortStopBits { get => portStopBits; set => serialPort.StopBits = portStopBits = value; }
        public Handshake PortHandshake { get => portHandshake; set => serialPort.Handshake = portHandshake = value; }


        public bool Open()
        {
            try
            {
                serialPort = new SerialPort(portName, portBaudRate, portParity, portDataBits, portStopBits);
                serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

                if (serialPort.IsOpen == false)
                {
                    serialPort.ReadTimeout = -1;
                    serialPort.WriteTimeout = -1;

                    serialPort.Open();
                    serialPort.DiscardInBuffer();    //Fix problem of received data in buffer befor port was opened
                    serialPort.DiscardOutBuffer();
                }
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        private void HabndleError(object sender, SerialErrorReceivedEventArgs e)
        {
            OnSerialErrorAccure(EventArgs.Empty);
        }


        public bool IsOpen()
        {
            return serialPort.IsOpen;
        }


        public bool Close()
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                serialPort.Close();
            }
            return serialPort.IsOpen;
        }


        public void Dispose()
        {
            if (serialPort != null)
            {
                serialPort.Dispose();
                serialPort = null;
            }
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            int count = 0;
            try
            {
                count = serialPort.BytesToRead;
            }
            catch (Exception ex)
            {
                if (ex is System.IO.IOException || ex is UnauthorizedAccessException)
                {
                    OnSerialErrorAccure(EventArgs.Empty);
                }
            }

            /*Form The Packet in The Buffer*/
            byte[] buf = new byte[count];
            int readBytes = Receive(buf, 0, count);

            if (readBytes > 0)
            {
                OnSerialReceive(buf);
            }

        }

        public void Transmit(byte[] packet)
        {
            serialPort.Write(packet, 0, packet.Length);
        }

        private int Receive(byte[] bytes, int offset, int count)
        {
            int readBytes = 0;
            if (count > 0)
            {
                readBytes = serialPort.Read(bytes, offset, count);
            }
            return readBytes;
        }

        private void OnSerialReceive(byte[] res)
        {
            OnSerialReceiving?.Invoke(this, new DataStreamEventArgs(res));
        }


        private void OnSerialErrorAccure(EventArgs e)
        {
            OnSerialError?.Invoke(this, e);
        }
    }

    public class DataStreamEventArgs : EventArgs
    {

        private byte[] _bytes;
        public DataStreamEventArgs(byte[] bytes)
        {
            _bytes = bytes;
        }

        public byte[] Response
        {
            get { return _bytes; }
        }

    } 
}
