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
    public partial class Form2 : Form
    {
        Saving _settings = new Saving();
        Form1 form;
        public Form2()
        {
            InitializeComponent();
            _settings = Saving.GetSetting("gpu.xml");
            try
            {
                listBox2.Items.Add(_settings.GPU_Brand);
                listBox2.Items.Add(_settings.GPU);
                listBox2.Items.Add(_settings.GPU_Memory);
            }
            catch (Exception ex)
            {
                listBox2.Items.Add("ТУТ ПУСТО");
            }
        }
     
        

        private void amd_gpu_CheckedChanged(object sender, EventArgs e)
        {
            if (amd_gpu.Checked)
            {
                type_of_gpu.Items.Clear();
                type_of_gpu.Items.Add("r9 370");
                type_of_gpu.Items.Add("r9 350");
                type_of_gpu.Items.Add("r9 320");
                type_of_gpu.Items.Add("r7 360");
                type_of_gpu.Items.Add("r7 350");
                type_of_gpu.Items.Add("tittan");
            }
        }

        private void nvidia_CheckedChanged(object sender, EventArgs e)
        {
            if (nvidia.Checked)
            {
                type_of_gpu.Items.Clear();
                type_of_gpu.Items.Add("geforce 1080");
                type_of_gpu.Items.Add("geforce 1050");
                type_of_gpu.Items.Add("geforce 1020");
                type_of_gpu.Items.Add("geforce 950");
                type_of_gpu.Items.Add("geforce 850");
                type_of_gpu.Items.Add("geforce 820");
            }
        }

        private void amd_gpu_CheckedChanged_1(object sender, EventArgs e)
        {
            if (amd_gpu.Checked)
            {
                type_of_gpu.Items.Clear();
                type_of_gpu.Items.Add("r9 370");
                type_of_gpu.Items.Add("r9 350");
                type_of_gpu.Items.Add("r9 320");
                type_of_gpu.Items.Add("r7 360");
                type_of_gpu.Items.Add("r7 350");
                type_of_gpu.Items.Add("tittan");
            }
        }

        private void type_of_cpu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void type_of_gpu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nvidia_CheckedChanged_1(object sender, EventArgs e)
        {
            if (nvidia.Checked)
            {
                type_of_gpu.Items.Clear();
                type_of_gpu.Items.Add("geforce 1080");
                type_of_gpu.Items.Add("geforce 1050");
                type_of_gpu.Items.Add("geforce 1020");
                type_of_gpu.Items.Add("geforce 950");
                type_of_gpu.Items.Add("geforce 850");
                type_of_gpu.Items.Add("geforce 820");
            }
        }

        private void gpu_memory_Scroll(object sender, EventArgs e)
        {
            amountgpu.Text = Convert.ToString(gpu_memory.Value + " ГБ");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            #region TYPE_OF_GPU
            var Cheaking_gpu = groupBox5.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            
            listBox2.Items.Insert(0, "Тип видеокарты: " + Cheaking_gpu.Text);
            _settings.GPU = (string)listBox2.Items[0];
            #endregion

            #region GPU
            if (type_of_gpu.Items.Count < 1)
            {
                listBox2.Items.Clear();
                listBox2.Items.Add("Вы забыли указать наименование видеокарты (");
            }
            else
            {
                listBox2.Items.Insert(1, "Наименование видеокарты: " + type_of_gpu.Text);
                _settings.GPU_Brand = (string)listBox2.Items[1];
            }
            #endregion

            #region AMOUNT
                 listBox2.Items.Insert(2, "Количество видеопамяти: " + amountgpu.Text + " ГБ");
                _settings.GPU_Memory = (string)listBox2.Items[2];

            _settings.Save("gpu.xml");
            #endregion
        }
    }
}
