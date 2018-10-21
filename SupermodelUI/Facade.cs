using IniParser;
using IniParser.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Reflection;
using System.Windows.Forms;
using System.Drawing;
using SupermodelUI.Forms;

namespace SupermodelUI
{
    public class Facade
    {
        #region ConfigData methods

        private static IniData CreateConfigFile()
        {
            FileIniDataParser parser = new FileIniDataParser();            
            IniData configFile = parser.ReadFile(ConfigData.localDirectory + ConfigData.iniLocation);
            configFile.Configuration.CaseInsensitive = false;

            return configFile;
        }

        public static List<IniSetting> GetIniSettings(string section = null)
        {
            bool sectionExists = false;
            List<IniSetting> iniSettings = new List<IniSetting>();
            SettingData settingData = new SettingData();
            List<FieldInfo> settings = Utils.GetConstants(settingData.GetType());
            IniData configFile = CreateConfigFile();

            foreach(SectionData sectionData in configFile.Sections)
            {
                if (sectionData.SectionName == section)
                {
                    sectionExists = true;
                }
            }

            if (sectionExists == false)
            {
                section = "Global";

                if (section != null)
                {
                    configFile.Sections.AddSection(section);
                }
            }

            foreach (var setting in settings)
            {
                string settingMetaData = setting.GetValue(null).ToString();
                settingMetaData = settingMetaData.Replace(" ", "");
                string[] settingValues = settingMetaData.Split(',');

                if (settingValues[1] == "joy")
                {
                    string keyValue = configFile[section][setting.Name];
                    if (keyValue != null)
                    {
                        keyValue = keyValue.Replace("\"", "");
                        string[] stripped = keyValue.Split(';');
                        List<string> keyBindingValues = stripped[0].Split(',').ToList();
                        int length = keyBindingValues.Count;


                        while (length < 3)
                        {
                            keyBindingValues.Add("");
                            length++;
                        }

                        IniSetting iniSetting = new IniSetting
                        {
                            key = setting.Name,
                            value = configFile[section][setting.Name],
                            settingType = settingValues[0],
                            type = settingValues[1],
                            //     boolValue = ToBoolean(configFile, setting.Name),
                            binding = settingValues[2],
                            keyBinding1 = keyBindingValues[0].Trim(),
                            keyBinding2 = keyBindingValues[1].Trim(),
                            keyBinding3 = keyBindingValues[2].Trim(),
                        };
                        iniSetting.boolValue = iniSetting.value != "0";
                        iniSettings.Add(iniSetting);
                    }
                }
                else
                {
                    IniSetting iniSetting = new IniSetting
                    {
                        key = setting.Name,
                        value = configFile[section][setting.Name],
                        settingType = settingValues[0],
                        type = settingValues[1],
                  //      boolValue = ToBoolean(configFile, setting.Name),
                        binding = settingValues[2]
                    };
                    iniSetting.boolValue = iniSetting.value != "0";
                    iniSettings.Add(iniSetting);
                }
            }

            return iniSettings;
        }

        #endregion

        #region bindings

        public static void BindControls(Form form, List<IniSetting> iniSettings, string romName = null)
        {
            foreach (Control control in form.Controls)
            {
                BindControl(control, iniSettings, romName);
            }
        }

        private static void BindControl(Control control, List<IniSetting> iniSettings, string romName = null)
        {
            if (control is CheckBox)
            {
                control.DataBindings.Clear();
                IniSetting formSetting = GetSettingFromForm(control, iniSettings);
                control.DataBindings.Add("CheckState", formSetting, "boolValue", true);
            }
            else if (control is TrackBar | control is NumericUpDown)
            {
                control.DataBindings.Clear();
                IniSetting formSetting = GetSettingFromForm(control, iniSettings);
                control.DataBindings.Add("Value", formSetting, "value", true);
            }
            else if (control is DataGridView)
            {
                (control as DataGridView).AutoGenerateColumns = false;

                if (romName == "game")
                {
                    (control as DataGridView).Columns.Add("title", "Title");
                    (control as DataGridView).Columns.Add("romName", "Rom");

                    (control as DataGridView).Columns[0].ReadOnly = true;
                    (control as DataGridView).Columns[1].ReadOnly = true;

                    (control as DataGridView).Columns["title"].DataPropertyName = "title";
                    (control as DataGridView).Columns["romName"].DataPropertyName = "romName";

                    List<Game> games = new List<Game>();
                    string xmlFilePath = ConfigData.localDirectory + ConfigData.xmlLocation;
                    XDocument gamelist = XDocument.Load(xmlFilePath);

                    string[] roms = gamelist.Elements("games").
                                        Elements("game").
                                        Attributes("name").
                                        Select(g => g.Value).
                                        ToArray();

                    string[] titles = gamelist.Descendants("game").
                                            Elements("identity").
                                            Elements("title").
                                            Select(g => g.Value).
                                            ToArray();

                    int max = roms.Length;

                    for (int i = 0; i < max; i++)
                    {
                        Game game = new Game
                        {
                            title = titles[i],
                            romName = roms[i]
                        };

                        games.Add(game);
                    }

                    (control as DataGridView).DataSource = games;
                }
                else if (romName != null)
                {
                    (control as DataGridView).Columns.Add("setting", "Setting");
                    (control as DataGridView).Columns.Add("keyBinding1", "Key Binding 1");
                    (control as DataGridView).Columns.Add("keyBinding2", "Key Binding 2");
                    (control as DataGridView).Columns.Add("keyBinding3", "Key Binding 3");

                    (control as DataGridView).Columns[0].ReadOnly = true;

                    (control as DataGridView).Columns["setting"].DataPropertyName = "key";
                    (control as DataGridView).Columns["keyBinding1"].DataPropertyName = "keyBinding1";
                    (control as DataGridView).Columns["keyBinding2"].DataPropertyName = "keyBinding2";
                    (control as DataGridView).Columns["keyBinding3"].DataPropertyName = "keyBinding3";

                    List<IniSetting> bindings = new List<IniSetting>();
                    List<string> controlTypes = GetControlTypes(romName);

                    foreach (string type in controlTypes)
                    {
                        bindings.AddRange(iniSettings.Where(ini => ini.settingType == type).ToList());
                    }

                    (control as DataGridView).DataSource = bindings;
                }
            }
            else if (control is ComboBox)
            {
                if (control.Name == "resolutionComboBox")
                {
                    IniSetting xSetting = iniSettings.Where(ini => ini.binding == "XResolution").First();
                    IniSetting ySetting = iniSettings.Where(ini => ini.binding == "YResolution").First();
                    (control as ComboBox).DataSource = GetResolutions();
                    string rez = xSetting.value + "x" + ySetting.value;
                    (control as ComboBox).SelectedItem = rez;
                }
            }
        }

        #endregion

        #region binding helpers

        private static IniSetting GetSettingFromForm(Control control, List<IniSetting> iniSettings)
        {
            IniSetting formSetting = iniSettings.Where(ini => ini.binding == control.Name).First();
            return formSetting;
        }

        private static List<string> GetResolutions()
        {
            List<string> resolutionsList = new List<string>();

            foreach (SettingData.resolutions resolution in Enum.GetValues(typeof(SettingData.resolutions)))
            {
                string[] rez = resolution.ToString().Split('y');
                string xRez = rez[0].Substring(1);
                string yRez = rez[1];
                string wholeRez = xRez + "x" + yRez;
                resolutionsList.Add(wholeRez);
            }

            return resolutionsList;
        }

        #region control types

        private static List<string> GetControlTypes(string romName)
        {
            List<string> controlTypes = new List<string>();
            string key = romName.Substring(0, 3);

            switch (key)
            {
                case "bas":
                case "get":
                    controlTypes.Add("fishing");
                    break;

                case "day":
                case "scu":
                    controlTypes.Add("racing");
                    controlTypes.Add("4speed");
                    controlTypes.Add("vr4");
                    break;

                case "dir":
                    controlTypes.Add("racing");
                    controlTypes.Add("2speed");
                    controlTypes.Add("vr1");
                    controlTypes.Add("handbrake");
                    break;

                case "eca":
                    controlTypes.Add("racing");
                    controlTypes.Add("2speed");
                    controlTypes.Add("vr1");
                    break;

                case "fvi":
                case "vf3":
                    controlTypes.Add("joystick");
                    controlTypes.Add("fighting");
                    break;

                case "har":
                    controlTypes.Add("racing");
                    controlTypes.Add("2speed");
                    controlTypes.Add("vr1");
                    controlTypes.Add("harley");
                    break;

                case "lam":
                case "oce":
                    controlTypes.Add("analoggun");
                    break;

                case "lem":
                    controlTypes.Add("racing");
                    controlTypes.Add("2speed");
                    controlTypes.Add("vr4");
                    break;

                case "los":
                    controlTypes.Add("digitalgun");
                    break;

                case "mag":
                    controlTypes.Add("truck");
                    break;

                case "ski":
                    controlTypes.Add("ski");
                    break;

                case "spi":
                    controlTypes.Add("joystick");
                    controlTypes.Add("spikeout");
                    break;

                case "sra":
                    controlTypes.Add("racing");
                    controlTypes.Add("4speed");
                    controlTypes.Add("vr1");
                    controlTypes.Add("handbrake");
                    break;

                case "swt":
                    controlTypes.Add("starwars");
                    break;

                case "sys":
                    controlTypes.Add("sys");
                    break;

                case "von":
                    controlTypes.Add("von");
                    break;

                case "vs2":
                    controlTypes.Add("joystick");
                    controlTypes.Add("striker");
                    break;
            }

            return controlTypes;
        }
        #endregion

        #endregion

     //   private static List<string> GetResolutions()
        //{
        //    List<string> resolutionsList = new List<string>();

        //    foreach (SettingData.resolutions resolution in Enum.GetValues(typeof(SettingData.resolutions)))
        //    {
        //        string[] rez = resolution.ToString().Split('y');
        //        string xRez = rez[0].Substring(1);
        //        string yRez = rez[1];
        //        string wholeRez = xRez + "x" + yRez;
        //        resolutionsList.Add(wholeRez);
        //    }

        //    return resolutionsList;
        //}

        #region Form Methods

        public static void Load(Form form, string section = "Global")
        {
            List<IniSetting> iniSettings = GetIniSettings(section);
            BindControls(form, iniSettings, section);
        }

        public static void Save(Form form, string section = "Global", List<IniSetting> iniSettings = null)
        {
            if (iniSettings == null)
            {
                iniSettings = GetIniSettings(section);
            }

            IniData configFile = CreateConfigFile();

            foreach (Control control in form.Controls)
            {
                SaveControl(control, iniSettings, configFile, section);
            }

            FileIniDataParser parser = new FileIniDataParser();
            parser.WriteFile(ConfigData.localDirectory + ConfigData.iniLocation, configFile);
        }

        private static void SaveControl(Control control, List<IniSetting> iniSettings, IniData configFile, string section)
        {
            if (control is CheckBox)
            {
                IniSetting formSetting = GetSettingFromForm(control, iniSettings);

                switch ((control as CheckBox).Checked)
                {
                    case true:
                        configFile[section][formSetting.key] = "1";
                        break;

                    case false:
                        configFile[section][formSetting.key] = "0";
                        break;
                }
            }
            else if (control is TrackBar | control is NumericUpDown)
            {
                {
                    IniSetting formSetting = GetSettingFromForm(control, iniSettings);
                    if (formSetting.value == "")
                    {
                        formSetting.value = "0";
                    }
                    configFile[section][formSetting.key] = formSetting.value;
                }
            }
            else if (control is DataGridView)
            {
                List<IniSetting> formSettings = formSettings = iniSettings.Where(ini => ini.type == "joy").ToList();

                foreach (IniSetting setting in formSettings)
                {
                    string value = "\"" + setting.keyBinding1;

                    if (setting.keyBinding2 != "")
                    {
                        value = value + "," + setting.keyBinding2;
                    }

                    if (setting.keyBinding3 != "")
                    {
                        value = value + "," + setting.keyBinding3;
                    }

                    value = value + "\"";

                    configFile[section][setting.key] = value;
                }
            }
            else if (control is ComboBox)
            {
                if (control.Name == "resolutionComboBox")
                {
                    string[] rez = (control as ComboBox).SelectedItem.ToString().Split('x');
                    configFile[section]["XResolution"] = rez[0];
                    configFile[section]["YResolution"] = rez[1];
                }
            }
        }

        public static void ShowMessageBox(Form parent, string message)
        {
            MessageBoxForm messageBox = new MessageBoxForm(parent, message);
            messageBox.ShowDialog();
        }

        public static Point CalculateStartPosition(Form parent, Form child)
        {
            Point startPosition = new Point();

            startPosition.X = parent.Location.X + (parent.Width - child.Width) / 2;
            startPosition.Y = parent.Location.Y + (parent.Height - child.Height) / 2;

            return startPosition;
        }



        #endregion
    }
} 
