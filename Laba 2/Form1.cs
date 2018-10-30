using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba_2
{
    public partial class Form1 : Form
    {
        List<object> obj = new List<object>();
        Form1 form1 = new Form1();
        public string Evm { get; set; }
        public string CPU { get; set; }
        public string CPU_Name { get; set; }
        public string ROM { get; set; }
        public string RAM_Type { get; set; }
        public string RAM { get; set; }
        public string OS { get; set; }
        public string GPU_Brand { get; set; }
        public string GPU { get; set; }
        public string GPU_Memory { get; set; }
        Saving _saving = null;
        public Form1()
        {
           
                  InitializeComponent();
                _saving = Saving.GetSetting("buf.xml");
            try
            {
                listBox1.Items.Add(Evm);
                listBox1.Items.Add(CPU);
                listBox1.Items.Add(CPU_Name);
                listBox1.Items.Add(RAM);
                listBox1.Items.Add(RAM_Type);
                listBox1.Items.Add(ROM);
                listBox1.Items.Add(OS);
            }
            catch(Exception ex)
            {
                listBox1.Items.Add("ТУТ ПУСТО");
            }

        }


        private void type_of_item_Enter(object sender, EventArgs e)
        {
        
        }

 
    

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void amount_rom_Scroll(object sender, EventArgs e)
        {
            amount_ram.Text = Convert.ToString(amountram.Value+" ГБ");
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            amountrom.Text= Convert.ToString(trackBar1.Value + " ГБ");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void type_of_os_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Event_Click(object sender, EventArgs e)
        {
            
            listBox1.Items.Clear();
            #region TYPE_OF_EVM
            var Cheaking_item = type_of_item.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            listBox1.Items.Insert(0, "Тип ЭВМ: " + Cheaking_item.Text);
            Evm = (string)listBox1.Items[0];
            #endregion

            #region TYPE_OF_CPU
            var Cheaking_cpu = groupBox2.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            listBox1.Items.Insert(1, "Тип Процессора: " + Cheaking_cpu.Text);
            CPU = (string)listBox1.Items[1];
            #endregion

            #region CPU
            if (type_of_cpu.Items.Count < 1)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Вы забыли указать наименование процессора (");
            }
            else
            {
                listBox1.Items.Insert(2, "Наименование процессора: " + type_of_cpu.Text);
                CPU_Name= (string)listBox1.Items[2];
            }
            #endregion

            #region AMOUNTRAM
            listBox1.Items.Insert(3, "Количество памяти ОЗУ: " + amountram.Value + " ГБ");
            RAM=(string)listBox1.Items[3];
            #endregion

            #region Type_of_rom

            var Cheaking_rom = groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            listBox1.Items.Insert(4, "Тип ПЗУ: " + Cheaking_rom.Text);
            RAM_Type= (string)listBox1.Items[4];
            #endregion

            #region AMOUNTROM
            listBox1.Items.Insert(5, "Количество памяти: " + trackBar1.Value + " ГБ");
            ROM=(string)listBox1.Items[5];
            #endregion

            #region OS
            for (int i = 0; i < type_of_os.CheckedItems.Count; i++)
            {
                listBox1.Items.Insert(6 + i, "Выбранная предустановленная ОС" + type_of_os.CheckedItems[i].ToString());
            }
            OS= (string)listBox1.Items[6];
            #endregion
            _saving.Save("buf.xml",);
        }


        private void intel_CheckedChanged(object sender, EventArgs e)
        {
            if (intel.Checked)
            {
                type_of_cpu.Items.Clear();
                type_of_cpu.Items.Add("Core i7");
                type_of_cpu.Items.Add("Core i5");
                type_of_cpu.Items.Add("Core i3");
                type_of_cpu.Items.Add("Pentium 4");
                type_of_cpu.Items.Add("Celeron");
                type_of_cpu.Items.Add("Xeon");
            }
        }

        private void amd_CheckedChanged(object sender, EventArgs e)
        {
            if (amd.Checked)
            {
                type_of_cpu.Items.Clear();
                type_of_cpu.Items.Add("FX");
                type_of_cpu.Items.Add("AX");
                type_of_cpu.Items.Add("Athlon 4");
            
            }
        }

        private void baikal_CheckedChanged(object sender, EventArgs e)
        {
            if (baikal.Checked)
            {
                type_of_cpu.Items.Clear();
                type_of_cpu.Items.Add("BAIKAL T1");
                type_of_cpu.Items.Add("BAIAKL M");
               

            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void type_of_cpu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {

        }

        private void gpu_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void h(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void About_Click(object sender, EventArgs e)
        {
            Form3 about = new Form3();
            about.Show();
        }

        private void SaveItem_Click(object sender, EventArgs e)
        {

        }

        private void window_search_Click(object sender, EventArgs e)
        {
            Form4 win_search = new Form4(); 
            win_search.Show();
        }
    }
}