using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Windows.Forms;
using IniParser;
using IniParser.Model;
using IniParser.Parser;

namespace SupermodelUI
{
    public class ConfigData
    {
        #region constants

        public static string iniLocation = "\\Config\\Supermodel.ini";
        public static string xmlLocation = "\\Config\\Games.xml";
        public const string g = "Global"; //hardcoded for now, gonna need to read this from the ini file 
        public static string localDirectory = System.Environment.CurrentDirectory;
        public string[] titles { get; set; }
        public string[] roms { get; set; }

        #endregion
    }
}

