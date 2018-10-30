using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba_2
{
    static class Program 
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main() 
        {
          //  Form1 form1 = new Form1();
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
         //   Serialize.XmlSerializeWrapper.Serialize<Form1,"asd" > ()
        }
    }
}
