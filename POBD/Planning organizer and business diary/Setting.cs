using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Planning_organizer_and_business_diary
{
    public class Setting
    {
        public static Setting GetSetting()
        {
            Setting setting = null;
            string filename = Globals.SettingsFile;

            if (File.Exists(filename))
            {
                using (FileStream fs = new FileStream(filename, FileMode.Open))
                {
                    XmlSerializer xser = new XmlSerializer(typeof(Setting));
                    setting = (Setting)xser.Deserialize(fs);
                    fs.Close();
                }
            }
            else setting = new Setting();
            return setting;
        }

        public void Save()
        {
            string filename = Globals.SettingsFile;
            if (File.Exists(filename)) File.Delete(filename);

            using (FileStream fileStream = new FileStream(filename, FileMode.Create))
            {
                XmlSerializer xser = new XmlSerializer(typeof(Setting));
                xser.Serialize(fileStream, this);
                fileStream.Close();
            }
        }

        public string Monday_Task { get; set; }
        public string Thuesday_Task  { get; set; }
        public string Wendesday_Task { get; set; }
        public string Thursday_Task { get; set; }
        public string Friday_Task { get; set; }
        public string Saturday_Task { get; set; }
        public string Sunday_Task { get; set; }



        


    }
}
