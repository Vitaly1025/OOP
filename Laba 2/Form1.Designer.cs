namespace Laba_2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.type_of_item = new System.Windows.Forms.GroupBox();
            this.server = new System.Windows.Forms.RadioButton();
            this.latop = new System.Windows.Forms.RadioButton();
            this.pc = new System.Windows.Forms.RadioButton();
            this.Event = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.baikal = new System.Windows.Forms.RadioButton();
            this.amd = new System.Windows.Forms.RadioButton();
            this.intel = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.type_of_cpu = new System.Windows.Forms.ComboBox();
            this.amountram = new System.Windows.Forms.TrackBar();
            this.type_of_os = new System.Windows.Forms.CheckedListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sshd = new System.Windows.Forms.RadioButton();
            this.hdd = new System.Windows.Forms.RadioButton();
            this.ssd = new System.Windows.Forms.RadioButton();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gpu = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.amount_ram = new System.Windows.Forms.Label();
            this.amountrom = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.About = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.window_search = new System.Windows.Forms.Button();
            this.type_of_item.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountram)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // type_of_item
            // 
            this.type_of_item.Controls.Add(this.server);
            this.type_of_item.Controls.Add(this.latop);
            this.type_of_item.Controls.Add(this.pc);
            this.type_of_item.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.type_of_item.Location = new System.Drawing.Point(65, 95);
            this.type_of_item.Name = "type_of_item";
            this.type_of_item.Size = new System.Drawing.Size(235, 115);
            this.type_of_item.TabIndex = 0;
            this.type_of_item.TabStop = false;
            this.type_of_item.Text = "Тип ЭВМ";
            this.type_of_item.Enter += new System.EventHandler(this.type_of_item_Enter);
            // 
            // server
            // 
            this.server.AutoSize = true;
            this.server.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.server.Location = new System.Drawing.Point(17, 75);
            this.server.Name = "server";
            this.server.Size = new System.Drawing.Size(75, 21);
            this.server.TabIndex = 2;
            this.server.TabStop = true;
            this.server.Text = "сервер";
            this.server.UseVisualStyleBackColor = true;
            // 
            // latop
            // 
            this.latop.AutoSize = true;
            this.latop.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.latop.Location = new System.Drawing.Point(17, 54);
            this.latop.Name = "latop";
            this.latop.Size = new System.Drawing.Size(81, 21);
            this.latop.TabIndex = 1;
            this.latop.TabStop = true;
            this.latop.Text = "ноутбук";
            this.latop.UseVisualStyleBackColor = true;
            // 
            // pc
            // 
            this.pc.AutoSize = true;
            this.pc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pc.Location = new System.Drawing.Point(17, 34);
            this.pc.Name = "pc";
            this.pc.Size = new System.Drawing.Size(48, 21);
            this.pc.TabIndex = 0;
            this.pc.TabStop = true;
            this.pc.Text = "ПК";
            this.pc.UseVisualStyleBackColor = true;
            // 
            // Event
            // 
            this.Event.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Event.Location = new System.Drawing.Point(1038, 399);
            this.Event.Name = "Event";
            this.Event.Size = new System.Drawing.Size(193, 68);
            this.Event.TabIndex = 1;
            this.Event.Text = "ЗАКАЗАТЬ";
            this.Event.UseVisualStyleBackColor = true;
            this.Event.Click += new System.EventHandler(this.Event_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.baikal);
            this.groupBox2.Controls.Add(this.amd);
            this.groupBox2.Controls.Add(this.intel);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(65, 233);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(235, 115);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Тип процессора";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // baikal
            // 
            this.baikal.AutoSize = true;
            this.baikal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.baikal.Location = new System.Drawing.Point(17, 75);
            this.baikal.Name = "baikal";
            this.baikal.Size = new System.Drawing.Size(77, 21);
            this.baikal.TabIndex = 2;
            this.baikal.TabStop = true;
            this.baikal.Text = "Байкал";
            this.baikal.UseVisualStyleBackColor = true;
            this.baikal.CheckedChanged += new System.EventHandler(this.baikal_CheckedChanged);
            // 
            // amd
            // 
            this.amd.AutoSize = true;
            this.amd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.amd.Location = new System.Drawing.Point(17, 54);
            this.amd.Name = "amd";
            this.amd.Size = new System.Drawing.Size(57, 21);
            this.amd.TabIndex = 1;
            this.amd.TabStop = true;
            this.amd.Text = "Amd";
            this.amd.UseVisualStyleBackColor = true;
            this.amd.CheckedChanged += new System.EventHandler(this.amd_CheckedChanged);
            // 
            // intel
            // 
            this.intel.AutoSize = true;
            this.intel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.intel.Location = new System.Drawing.Point(17, 34);
            this.intel.Name = "intel";
            this.intel.Size = new System.Drawing.Size(55, 21);
            this.intel.TabIndex = 0;
            this.intel.TabStop = true;
            this.intel.Text = "Intel";
            this.intel.UseVisualStyleBackColor = true;
            this.intel.CheckedChanged += new System.EventHandler(this.intel_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.type_of_cpu);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(65, 354);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(235, 105);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Наименнование процессора";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // type_of_cpu
            // 
            this.type_of_cpu.FormattingEnabled = true;
            this.type_of_cpu.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.type_of_cpu.Location = new System.Drawing.Point(17, 60);
            this.type_of_cpu.Name = "type_of_cpu";
            this.type_of_cpu.Size = new System.Drawing.Size(175, 33);
            this.type_of_cpu.Sorted = true;
            this.type_of_cpu.TabIndex = 0;
            this.type_of_cpu.SelectedIndexChanged += new System.EventHandler(this.type_of_cpu_SelectedIndexChanged);
            // 
            // amountram
            // 
            this.amountram.LargeChange = 4;
            this.amountram.Location = new System.Drawing.Point(65, 505);
            this.amountram.Maximum = 32;
            this.amountram.Minimum = 4;
            this.amountram.Name = "amountram";
            this.amountram.Size = new System.Drawing.Size(206, 56);
            this.amountram.SmallChange = 2;
            this.amountram.TabIndex = 4;
            this.amountram.TabStop = false;
            this.amountram.TickFrequency = 4;
            this.amountram.Value = 4;
            this.amountram.Scroll += new System.EventHandler(this.amount_rom_Scroll);
            // 
            // type_of_os
            // 
            this.type_of_os.FormattingEnabled = true;
            this.type_of_os.Items.AddRange(new object[] {
            "macOS",
            "Linux",
            "Windows"});
            this.type_of_os.Location = new System.Drawing.Point(339, 236);
            this.type_of_os.Name = "type_of_os";
            this.type_of_os.Size = new System.Drawing.Size(110, 72);
            this.type_of_os.TabIndex = 5;
            this.type_of_os.SelectedIndexChanged += new System.EventHandler(this.type_of_os_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sshd);
            this.groupBox1.Controls.Add(this.hdd);
            this.groupBox1.Controls.Add(this.ssd);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(71, 575);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 133);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Тип жёсткого диска";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // sshd
            // 
            this.sshd.AutoSize = true;
            this.sshd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sshd.Location = new System.Drawing.Point(20, 96);
            this.sshd.Name = "sshd";
            this.sshd.Size = new System.Drawing.Size(67, 21);
            this.sshd.TabIndex = 2;
            this.sshd.TabStop = true;
            this.sshd.Text = "SSHD";
            this.sshd.UseVisualStyleBackColor = true;
            // 
            // hdd
            // 
            this.hdd.AutoSize = true;
            this.hdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hdd.Location = new System.Drawing.Point(20, 75);
            this.hdd.Name = "hdd";
            this.hdd.Size = new System.Drawing.Size(59, 21);
            this.hdd.TabIndex = 1;
            this.hdd.TabStop = true;
            this.hdd.Text = "HDD";
            this.hdd.UseVisualStyleBackColor = true;
            // 
            // ssd
            // 
            this.ssd.AutoSize = true;
            this.ssd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ssd.Location = new System.Drawing.Point(20, 55);
            this.ssd.Name = "ssd";
            this.ssd.Size = new System.Drawing.Size(57, 21);
            this.ssd.TabIndex = 0;
            this.ssd.TabStop = true;
            this.ssd.Text = "SSD";
            this.ssd.UseVisualStyleBackColor = true;
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 200;
            this.trackBar1.Location = new System.Drawing.Point(339, 128);
            this.trackBar1.Maximum = 1000;
            this.trackBar1.Minimum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(200, 56);
            this.trackBar1.SmallChange = 100;
            this.trackBar1.TabIndex = 6;
            this.trackBar1.TickFrequency = 100;
            this.trackBar1.Value = 100;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(75, 477);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Количество ОЗУ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(347, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Количество ПЗУ";
            // 
            // gpu
            // 
            this.gpu.Location = new System.Drawing.Point(342, 354);
            this.gpu.Name = "gpu";
            this.gpu.Size = new System.Drawing.Size(107, 39);
            this.gpu.TabIndex = 9;
            this.gpu.Text = "Видеокарта";
            this.gpu.UseVisualStyleBackColor = true;
            this.gpu.Click += new System.EventHandler(this.gpu_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(337, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(252, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Предустановленная ОС";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(806, 170);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(425, 212);
            this.listBox1.TabIndex = 11;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.h);
            // 
            // amount_ram
            // 
            this.amount_ram.AutoSize = true;
            this.amount_ram.Location = new System.Drawing.Point(132, 544);
            this.amount_ram.Name = "amount_ram";
            this.amount_ram.Size = new System.Drawing.Size(0, 17);
            this.amount_ram.TabIndex = 12;
            // 
            // amountrom
            // 
            this.amountrom.AutoSize = true;
            this.amountrom.Location = new System.Drawing.Point(413, 173);
            this.amountrom.Name = "amountrom";
            this.amountrom.Size = new System.Drawing.Size(0, 17);
            this.amountrom.TabIndex = 13;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            this.fileSystemWatcher1.Changed += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Changed);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1320, 27);
            this.toolStrip1.TabIndex = 14;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.About,
            this.SaveItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(34, 24);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // About
            // 
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(181, 26);
            this.About.Text = "О программе";
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // SaveItem
            // 
            this.SaveItem.Name = "SaveItem";
            this.SaveItem.Size = new System.Drawing.Size(181, 26);
            this.SaveItem.Text = "Сохранить";
            this.SaveItem.Click += new System.EventHandler(this.SaveItem_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Location = new System.Drawing.Point(0, 27);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1320, 25);
            this.toolStrip2.TabIndex = 15;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // window_search
            // 
            this.window_search.Location = new System.Drawing.Point(1062, 95);
            this.window_search.Name = "window_search";
            this.window_search.Size = new System.Drawing.Size(153, 61);
            this.window_search.TabIndex = 16;
            this.window_search.Text = "Перейти к окну поиска";
            this.window_search.UseVisualStyleBackColor = true;
            this.window_search.Click += new System.EventHandler(this.window_search_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 723);
            this.Controls.Add(this.window_search);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.amountrom);
            this.Controls.Add(this.amount_ram);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gpu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.type_of_os);
            this.Controls.Add(this.amountram);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.Event);
            this.Controls.Add(this.type_of_item);
            this.Name = "Form1";
            this.Text = "Form1";
            this.type_of_item.ResumeLayout(false);
            this.type_of_item.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.amountram)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox type_of_item;
        private System.Windows.Forms.RadioButton server;
        private System.Windows.Forms.RadioButton latop;
        private System.Windows.Forms.RadioButton pc;
        private System.Windows.Forms.Button Event;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton baikal;
        private System.Windows.Forms.RadioButton amd;
        private System.Windows.Forms.RadioButton intel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox type_of_cpu;
        private System.Windows.Forms.TrackBar amountram;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton sshd;
        private System.Windows.Forms.RadioButton hdd;
        private System.Windows.Forms.RadioButton ssd;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button gpu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label amount_ram;
        private System.Windows.Forms.Label amountrom;
        public System.Windows.Forms.CheckedListBox type_of_os;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem About;
        private System.Windows.Forms.ToolStripMenuItem SaveItem;
        private System.Windows.Forms.Button window_search;
    }
}

