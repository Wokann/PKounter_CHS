using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokemonCounter
{
    class Lib
    {
        public static string dataFile = "PKData.txt";
        public static string configFile = "config.txt";

        public static int Visor = 0;
        public static bool Completed;
        public static bool OOF;
        public static bool importedPicture;
        public static string importedFilePicture;
        public static bool exportedCounter;
        public static string exportedFileCounter;
        public static decimal counterRatio;
        public static bool autosave;
        public static int actualHuntID = 0;
        public static string hotkeyReset;
        public static bool Vertical = false;
        public static string[] PkmnNamesList = PokemonNames.PkmnNames();
        public static string[] PkmnEngNamesList = PokemonNames.PkmnEngNames();
        public static string[] PkmnNamesSortedList = PokemonNames.PkmnNames();
        public static string[] PkmnEngNamesSortedList = PokemonNames.PkmnEngNames();
        public static string[] PkmnNamesNumberedList = PokemonNames.PkmnNames();
        public static string[][] GamesList =
            {
                new string[] { "绿", "红/蓝", "黄"},
                new string[] { "水晶", "金", "银"},
                new string[] { "绿宝石", "红宝石/蓝宝石", "火红/叶绿"},
                new string[] { "钻石/珍珠", "白金", "心金/魂银"},
                new string[] { "黑/白"},
                new string[] { "X/Y 及之后"},
            };

        public static List<MainForm> mainForms = new List<MainForm>();
        public static List<PkmnProperties> properties = new List<PkmnProperties>();
        public static List<Hunt> HuntsList = new List<Hunt>();
        
        public static Color ColorMain = Color.FromArgb(64, 64, 64);
        public static Color ColorAccent = SystemColors.ControlDarkDark;

        public static string ReadData(string filePath)
        {
            string jsonData = "";
            if (!File.Exists(filePath)) File.Create(filePath);
            using (FileStream stream = File.Open(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    while (!reader.EndOfStream)
                    {
                        jsonData = reader.ReadToEnd();
                    }
                }
            }
            return jsonData;
        }
        public static void DeleteHunt(int[] HuntID)
        {
            string jsonData = ReadData(dataFile);
            List<Hunt> Hunts = JsonConvert.DeserializeObject<List<Hunt>>(jsonData);

            for (int i = 0; i < Hunts.Count; i++)
            {
                if (HuntID.Contains(Hunts[i].ID))
                {
                    Hunts.Remove(Hunts[i]);
                    i--;
                }
            }
            jsonData = JsonConvert.SerializeObject(Hunts);
            File.WriteAllText(dataFile, jsonData);
        }
        public static void FillHunts(string jsonData, DataGridView DGV_ToFill)
        {
            DGV_ToFill.Rows.Clear();
            bool iconFolder = false;
            List<Hunt> huntsData = JsonConvert.DeserializeObject<List<Hunt>>(jsonData);
            for (int i = 0; i < huntsData.Count; i++)
            {
                Image pkmnIcon;
                string pkmnName = "";
                int pkmnIndex = huntsData[i].pkmnIndex;
                string dexnmb = (pkmnIndex + 1).ToString();
                int encounters = Convert.ToInt32(huntsData[i].counterValue);
                int ratio = Convert.ToInt32(huntsData[i].counterRatio);
                bool alpha = huntsData[i].alpha;
                bool completed = huntsData[i].complete;
                bool shiny = huntsData[i].shiny;
                int huntId = huntsData[i].ID;
                int genIndex = huntsData[i].genIndex;
                int gameIndex = huntsData[i].gameIndex;
                bool animated = huntsData[i].animated;
                bool autosave = huntsData[i].autosave;

                string addHotkey = huntsData[i].addHotkey;
                string subHotkey = huntsData[i].subHotkey;
                string resetHotkey = huntsData[i].resetHotkey;

                bool exportCounter = huntsData[i].exportCounter;
                string exportFileCounter = huntsData[i].exportFileCounter;

                bool importPicture = huntsData[i].importPicture;
                string importFilePicture = huntsData[i].importFilePicture;

                if (alpha)
                {
                    dexnmb = (Array.IndexOf(PkmnNamesList, PkmnNamesSortedList[pkmnIndex]) + 1).ToString();
                    pkmnName = PkmnNamesSortedList[pkmnIndex];
                }
                else pkmnName = PkmnNamesList[pkmnIndex];
                while (dexnmb.Length < 3) dexnmb = "0" + dexnmb;

                string iconFile = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\";
                iconFile += "icons\\";
                if (shiny) iconFile += "shiny\\";
                else iconFile += "normal\\";
                iconFile += dexnmb + ".png";
                
                try
                {
                    pkmnIcon = Image.FromFile(iconFile);
                }
                catch
                {
                    pkmnIcon = Properties.Resources.egg;
                    iconFolder = true;
                }
                object[] insertValues =
                {
                        completed,
                        pkmnIcon,
                        dexnmb,
                        pkmnName,
                        encounters,
                        ratio,
                        huntId,
                        alpha,
                        pkmnIndex,
                        genIndex,
                        gameIndex,
                        shiny,
                        animated,
                        autosave,
                        addHotkey,
                        subHotkey,
                        resetHotkey,
                        exportCounter,
                        exportFileCounter,
                        importPicture,
                        importFilePicture
                };
                DGV_ToFill.Rows.Add(insertValues);
            }
            if (iconFolder) MessageBox.Show("图标文件丢失。");
        }
        public static void SaveHunt(int huntID, bool autoSave, int genIndex, int gameIndex, int pkmnIndex, decimal counterValue, decimal counterRatio, bool alpha, bool shiny,
            bool animated, bool complete, string addHotkey, string subHotkey, string resetHotkey, bool exportCounter, string exportFileCounter, bool importPicture, string importFilePicture)
        {
            string jsonData = ReadData();
            int existingPosition = 0;
            bool alreadyexists = false;
            List<Hunt> Hunts = new List<Hunt>();
            if (jsonData != "") Hunts = JsonConvert.DeserializeObject<List<Hunt>>(jsonData);
            for (int i = 0; i < Hunts.Count; i++)
            {
                if (Hunts[i].ID == huntID)
                {
                    alreadyexists = true;
                    existingPosition = i;
                }
            }
            if (alreadyexists)
            {
                Hunts[existingPosition].genIndex = genIndex;
                Hunts[existingPosition].gameIndex = gameIndex;
                Hunts[existingPosition].pkmnIndex = pkmnIndex;
                Hunts[existingPosition].counterValue = counterValue;
                Hunts[existingPosition].counterRatio = counterRatio;

                Hunts[existingPosition].alpha = alpha;
                Hunts[existingPosition].shiny = shiny;
                Hunts[existingPosition].animated = animated;
                Hunts[existingPosition].complete = complete;
                Hunts[existingPosition].autosave = autoSave;
                
                Hunts[existingPosition].addHotkey = addHotkey;
                Hunts[existingPosition].subHotkey = subHotkey;
                Hunts[existingPosition].resetHotkey = resetHotkey;

                Hunts[existingPosition].exportCounter = exportCounter;
                Hunts[existingPosition].exportFileCounter = exportFileCounter;

                Hunts[existingPosition].importPicture = importPicture;
                Hunts[existingPosition].importFilePicture = importFilePicture;
            }
            else
            {
                int lastId = 0;
                if (Hunts.Count > 0) lastId = Hunts[Hunts.Count - 1].ID;

                Hunt newHunt = new Hunt();
                newHunt.ID = lastId + 1;

                newHunt.genIndex = genIndex;
                newHunt.gameIndex = gameIndex;
                newHunt.pkmnIndex = pkmnIndex;
                newHunt.counterValue = counterValue;
                newHunt.counterRatio = counterRatio;

                newHunt.alpha = alpha;
                newHunt.shiny = shiny;
                newHunt.animated = animated;
                newHunt.complete = complete;
                newHunt.autosave = autosave;

                newHunt.addHotkey = addHotkey;
                newHunt.subHotkey = subHotkey;
                newHunt.resetHotkey = resetHotkey;

                newHunt.exportCounter = exportCounter;
                newHunt.exportFileCounter = exportFileCounter;

                newHunt.importPicture = importPicture;
                newHunt.importFilePicture = importFilePicture;

                Hunts.Add(newHunt);
            }
            jsonData = JsonConvert.SerializeObject(Hunts);
            File.WriteAllText(dataFile, jsonData);
        }

        public static GlobalKeyboardHook gHook;
        public static void gHook_KeyDown(object sender, KeyEventArgs e)
        {
            Keys modifierKeys = e.Modifiers;
            Keys pressedKey = e.KeyData ^ modifierKeys; //remove modifier keys
            //do stuff with pressed and modifier keys
            var converter = new KeysConverter();
            string heldkeys = converter.ConvertToString(e.KeyData);
            for (int i = 0; i < Lib.HuntsList.Count; i++)
            {
                if (Lib.HuntsList[i].addHotkey == heldkeys)
                    Lib.HuntsList[i].counter.Text = (Convert.ToInt32(Lib.HuntsList[i].counter.Text) + Convert.ToInt32(Lib.HuntsList[i].counterRatio)).ToString();
                if (Lib.HuntsList[i].subHotkey == heldkeys)
                    if (Convert.ToInt32(Lib.HuntsList[i].counter.Text) > 0)
                    {
                        Lib.HuntsList[i].counter.Text = (Convert.ToInt32(Lib.HuntsList[i].counter.Text) - Convert.ToInt32(Lib.HuntsList[i].counterRatio)).ToString();
                    }
                    else
                    {
                        Lib.HuntsList[i].counter.Text = "0";
                    }
                if (Lib.HuntsList[i].resetHotkey == heldkeys)
                    Lib.HuntsList[i].counter.Text = "0";
            }
        }
        public static void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            Keys modifierKeys = e.Modifiers;
            Keys pressedKey = e.KeyData ^ modifierKeys; //remove modifier keys
            //do stuff with pressed and modifier keys
            var converter = new KeysConverter();
            string heldkeys = converter.ConvertToString(e.KeyData);
            for (int i = 0; i < Lib.HuntsList.Count; i++)
            {
                if (Lib.HuntsList[i].addHotkey == heldkeys)
                    Lib.HuntsList[i].counter.Text = (Convert.ToInt32(Lib.HuntsList[i].counter.Text) + Convert.ToInt32(Lib.HuntsList[i].counterRatio)).ToString();
                if (Lib.HuntsList[i].subHotkey == heldkeys)
                {
                    if (Convert.ToInt32(Lib.HuntsList[i].counter.Text) > 0)
                    {
                        Lib.HuntsList[i].counter.Text = (Convert.ToInt32(Lib.HuntsList[i].counter.Text) - Convert.ToInt32(Lib.HuntsList[i].counterRatio)).ToString();
                    }
                    else
                    {
                        Lib.HuntsList[i].counter.Text = "0";
                    }
                }
                if (Lib.HuntsList[i].resetHotkey == heldkeys)
                    Lib.HuntsList[i].counter.Text = "0";
            }
        }

        public static string[] PkmnNameException(string[] source, int[] positions, string[] exceptions)
        {
            string[] result = new string[807];
            Array.Copy(source,result,source.Length);
            for (int i = 0; i < positions.Length; i++)
            {
                result[positions[i]] = exceptions[i];
            }
            return result;
        }

        public static string ReadData()
        {
            string jsonData = "";
            if (!File.Exists(dataFile)) File.Create(dataFile);
            using (FileStream stream = File.Open(dataFile, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    while (!reader.EndOfStream)
                    {
                        jsonData = reader.ReadToEnd();
                    }
                }
            }
            return jsonData;
        }
        public static void UpdateHunts()
        {
            string jsonData = ReadData();
            for (int i = 0; i < HuntsList.Count; i++)
            {
                if (HuntsList[i].autosave)
                {
                    int huntID = HuntsList[i].ID;
                    bool autoSave = HuntsList[i].autosave;
                    int genIndex = HuntsList[i].genIndex;
                    int gameIndex = HuntsList[i].gameIndex;
                    int pkmnIndex = HuntsList[i].pkmnIndex;
                    decimal counterValue = Convert.ToDecimal(HuntsList[i].counter.Text);
                    decimal counterRatio = HuntsList[i].counterRatio;

                    bool alpha = HuntsList[i].alpha;
                    bool shiny = HuntsList[i].shiny;
                    bool animated = HuntsList[i].animated;
                    bool complete = HuntsList[i].complete;

                    string addHotkey = HuntsList[i].addHotkey;
                    string subHotkey = HuntsList[i].subHotkey;
                    string resetHotkey = HuntsList[i].resetHotkey;

                    bool exportCounter = HuntsList[i].exportCounter;
                    string exportFileCounter = HuntsList[i].exportFileCounter;

                    bool importPicture = HuntsList[i].importPicture;
                    string importFilePicture = HuntsList[i].importFilePicture;
                    Lib.SaveHunt(huntID, autoSave, genIndex, gameIndex, pkmnIndex, counterValue, counterRatio, alpha, shiny, animated,
                        complete, addHotkey, subHotkey, resetHotkey, exportCounter, exportFileCounter, importPicture, importFilePicture);
                }
            }
        }

        public class Hunt
        {
            public int ID { get; set; }

            public PictureBox pic { get; set; }
            public Label pkmnName { get; set; }
            public Label counter { get; set; }
            public Button counterAdd { get; set; }
            public Button counterSub { get; set; }

            public int genIndex { get; set; }
            public int gameIndex { get; set; }
            public int pkmnIndex { get; set; }
            public decimal counterValue { get; set; }
            public decimal counterRatio { get; set; }

            public bool alpha { get; set; }
            public bool shiny { get; set; }
            public bool animated { get; set; }
            public bool complete { get; set; }
            public bool autosave { get; set; }
            
            public string addHotkey { get; set; }
            public string subHotkey { get; set; }
            public string resetHotkey { get; set; }

            public bool exportCounter { get; set; }
            public string exportFileCounter { get; set; }
            
            public bool importPicture { get; set; }
            public string importFilePicture { get; set; }
        }
        public class fileConfig
        {
            public bool AOT { get; set; }
            public bool OOF { get; set; }
            public bool Vertical { get; set; }
            public Color Main { get; set; }
            public Color Accent { get; set; }
        }
    }
}
