using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Xexml
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            LoadXML();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        public static void LoadXML()
        {
            string path = "TheatreInfo.xml";
            if (!File.Exists(path))
            {
                return;
            }
            try
            {
                MemoryStream rawData = new MemoryStream(File.ReadAllBytes(path));
                XmlSerializer xmls = new XmlSerializer(typeof(TheatricalPerformance));
                var xmlList = (TheatricalPerformance)xmls.Deserialize(rawData); 
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
