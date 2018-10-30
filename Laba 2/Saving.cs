using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;


namespace Laba_2
{
    [Serializable]
    public class Saving
    {

        public List<Object> obj=new List<Object>();

        public static Saving GetSetting(string filename)
            {
                  Saving saving = null;

               if (File.Exists(filename))
                {
                    using(FileStream fs = new FileStream(filename, FileMode.Open))
                    {
                        
                        XmlSerializer formatter = new XmlSerializer(typeof(Saving));
                        saving = (Saving)formatter.Deserialize(fs);
                        fs.Close();
                    }
                }
                else  saving=new Saving();

                    return saving;
                
            }

            public  void Save(string filename,List<Object> obj)
            {
                using (FileStream fs = new FileStream(filename, FileMode.Create))
                {
                    XmlSerializer formatter = new XmlSerializer(typeof(Saving));
                    formatter.Serialize(fs,obj);
                    fs.Close();
                }
            }


           
    }
}
