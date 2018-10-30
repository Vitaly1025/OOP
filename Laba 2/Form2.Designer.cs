namespace Laba_2
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.nvidia = new System.Windows.Forms.RadioButton();
            this.amd_gpu = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.amountgpu = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gpu_memory = new System.Windows.Forms.TrackBar();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.type_of_gpu = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gpu_memory)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.nvidia);
            this.groupBox5.Controls.Add(this.amd_gpu);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox5.Location = new System.Drawing.Point(12, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(235, 146);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "ФИРМА ВИДЕОКАРТЫ";
            // 
            // nvidia
            // 
            this.nvidia.AutoSize = true;
            this.nvidia.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nvidia.Location = new System.Drawing.Point(17, 97);
            this.nvidia.Name = "nvidia";
            this.nvidia.Size = new System.Drawing.Size(66, 21);
            this.nvidia.TabIndex = 2;
            this.nvidia.TabStop = true;
            this.nvidia.Text = "nvidia";
            this.nvidia.UseVisualStyleBackColor = true;
            this.nvidia.CheckedChanged += new System.EventHandler(this.nvidia_CheckedChanged_1);
            // 
            // amd_gpu
            // 
            this.amd_gpu.AutoSize = true;
            this.amd_gpu.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.amd_gpu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.amd_gpu.Location = new System.Drawing.Point(17, 70);
            this.amd_gpu.Name = "amd_gpu";
            this.amd_gpu.Size = new System.Drawing.Size(56, 21);
            this.amd_gpu.TabIndex = 0;
            this.amd_gpu.TabStop = true;
            this.amd_gpu.Text = "amd";
            this.amd_gpu.UseVisualStyleBackColor = true;
            this.amd_gpu.CheckedChanged += new System.EventHandler(this.amd_gpu_CheckedChanged_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(577, 331);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 64);
            this.button2.TabIndex = 13;
            this.button2.Text = "Запомнить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // amountgpu
            // 
            this.amountgpu.AutoSize = true;
            this.amountgpu.Location = new System.Drawing.Point(418, 94);
            this.amountgpu.Name = "amountgpu";
            this.amountgpu.Size = new System.Drawing.Size(0, 17);
            this.amountgpu.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(353, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Графическая память";
            // 
            // gpu_memory
            // 
            this.gpu_memory.LargeChange = 2;
            this.gpu_memory.Location = new System.Drawing.Point(358, 64);
            this.gpu_memory.Maximum = 8;
            this.gpu_memory.Minimum = 1;
            this.gpu_memory.Name = "gpu_memory";
            this.gpu_memory.Size = new System.Drawing.Size(227, 56);
            this.gpu_memory.TabIndex = 14;
            this.gpu_memory.TickFrequency = 2;
            this.gpu_memory.Value = 1;
            this.gpu_memory.Scroll += new System.EventHandler(this.gpu_memory_Scroll);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.type_of_gpu);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox6.Location = new System.Drawing.Point(12, 204);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(235, 105);
            this.groupBox6.TabIndex = 17;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Наименование GPU";
            // 
            // type_of_gpu
            // 
            this.type_of_gpu.FormattingEnabled = true;
            this.type_of_gpu.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.type_of_gpu.Location = new System.Drawing.Point(17, 60);
            this.type_of_gpu.Name = "type_of_gpu";
            this.type_of_gpu.Size = new System.Drawing.Size(175, 33);
            this.type_of_gpu.Sorted = true;
            this.type_of_gpu.TabIndex = 0;
            this.type_of_gpu.SelectedIndexChanged += new System.EventHandler(this.type_of_gpu_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(478, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "ВИДЕОКАРТА";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(419, 155);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(344, 132);
            this.listBox2.TabIndex = 18;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 423);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.amountgpu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gpu_memory);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gpu_memory)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton nvidia;
        private System.Windows.Forms.RadioButton amd_gpu;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label amountgpu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar gpu_memory;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox type_of_gpu;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ListBox listBox2;
    }
}