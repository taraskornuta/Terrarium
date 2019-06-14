using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//public string MP1_Text { get => macroField1.tb_MacroData.Text; set => macroField1.tb_MacroData.Text = value; }
//public bool MP1_HexMode { get => macroField1.HexMode; set => macroField1.HexMode = value; }
//public decimal MP1_RepeatTime { get => macroField1.RepeatTimeValue; set => macroField1.RepeatTimeValue = value; }
//public bool MP1_Repeat { get => macroField1.RepeatActive; set => macroField1.RepeatActive = value; }
//public string MP1_ButtonText { get => macroField1.ButtonText; set => macroField1.ButtonText = value; }



namespace Terrarium
{
    [Serializable()]
    public class MacroPanelConfig
    {
        private string[] fieldData;
        private string[] buttonText;
        private bool[] hexMode;
        private decimal[] repeatTime;

        public string[] FieldData { get => fieldData; set => fieldData = value; }
        public string[] ButtonText { get => buttonText; set => buttonText = value; }
        public bool[] HexMode { get => hexMode; set => hexMode = value; }
        public decimal[] RepeatTime { get => repeatTime; set => repeatTime = value; }

    }

    class ConfigManager
    {
        private MacroPanelConfig macroFieldConfig = new MacroPanelConfig();
        public MacroPanelConfig Config
        {
            get { return macroFieldConfig; }
            set { macroFieldConfig = value; }
        }

        // Load configuration file
        public void LoadConfig(string filePath)
        {
            if (System.IO.File.Exists(filePath))
            {
                System.IO.StreamReader srReader = System.IO.File.OpenText(filePath);
                Type tType = macroFieldConfig.GetType();
                System.Xml.Serialization.XmlSerializer xsSerializer = new System.Xml.Serialization.XmlSerializer(tType);
                object oData = xsSerializer.Deserialize(srReader);
                macroFieldConfig = (MacroPanelConfig)oData;
                srReader.Close();
            }
        }

        // Save configuration file
        public void SaveConfig(string filePath)
        {
            System.IO.StreamWriter swWriter = System.IO.File.CreateText(filePath);
            Type tType = macroFieldConfig.GetType();
            if (tType.IsSerializable)
            {
                System.Xml.Serialization.XmlSerializer xsSerializer = new System.Xml.Serialization.XmlSerializer(tType);
                xsSerializer.Serialize(swWriter, macroFieldConfig);
                swWriter.Close();
            }
        }

        // Returns file name from path
        public string GetFileName(string filePath)
        {
            return System.IO.Path.GetFileName(filePath);
        }
    }
}
