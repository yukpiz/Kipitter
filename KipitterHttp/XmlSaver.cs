using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace KipitterCore
{
    public static class XmlSaver
    {
        private static string genFilePath(string name)
        {
            return AppDomain.CurrentDomain.SetupInformation.ApplicationBase + name + ".xml";
        }

        public static void Save(string name, AlarmData[] alarms)
        {
        }

        public static AlarmData[] Load(string name)
        {
            //Generate file path.
            string path = genFilePath(name);

            //Check for exists of a file.
            if (!File.Exists(path)) return null;

            //Load of xml to object.
            AlarmData[] alarms = null;
            XmlSerializer serializer = new XmlSerializer(typeof(AlarmData[]));
            StreamReader reader = new StreamReader(path, new UTF8Encoding(false));
            alarms = (AlarmData[])serializer.Deserialize(reader);

            //Cleanup objects.
            reader.Close();
            reader = null;
            serializer = null;

            return alarms;
        }
    }
}
