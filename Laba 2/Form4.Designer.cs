namespace Laba_2
{
    partial class Form4
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
            this.Search = new System.Windows.Forms.Button();
            this.Searchbox = new System.Windows.Forms.TextBox();
            this.type_of_item = new System.Windows.Forms.GroupBox();
            this.all_search = new System.Windows.Forms.RadioButton();
            this.gpu_search = new System.Windows.Forms.RadioButton();
            this.cpu_search = new System.Windows.Forms.RadioButton();
            this.SearchResult = new System.Windows.Forms.ListBox();
            this.type_of_item.SuspendLayout();
            this.SuspendLayout();
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(869, 27);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(98, 35);
            this.Search.TabIndex = 19;
            this.Search.Text = "Найти";
            this.Search.UseVisualStyleBackColor = true;
            // 
            // Searchbox
            // 
            this.Searchbox.Location = new System.Drawing.Point(482, 27);
            this.Searchbox.Multiline = true;
            this.Searchbox.Name = "Searchbox";
            this.Searchbox.Size = new System.Drawing.Size(381, 35);
            this.Searchbox.TabIndex = 18;
            // 
            // type_of_item
            // 
            this.type_of_item.Controls.Add(this.all_search);
            this.type_of_item.Controls.Add(this.gpu_search);
            this.type_of_item.Controls.Add(this.cpu_search);
            this.type_of_item.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.type_of_item.Location = new System.Drawing.Point(482, 68);
            this.type_of_item.Name = "type_of_item";
            this.type_of_item.Size = new System.Drawing.Size(488, 68);
            this.type_of_item.TabIndex = 20;
            this.type_of_item.TabStop = false;
            this.type_of_item.Text = "Поиск";
            // 
            // all_search
            // 
            this.all_search.AutoSize = true;
            this.all_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.all_search.Location = new System.Drawing.Point(387, 34);
            this.all_search.Name = "all_search";
            this.all_search.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.all_search.Size = new System.Drawing.Size(69, 21);
            this.all_search.TabIndex = 2;
            this.all_search.TabStop = true;
            this.all_search.Text = "Везде";
            this.all_search.UseVisualStyleBackColor = true;
            // 
            // gpu_search
            // 
            this.gpu_search.AutoSize = true;
            this.gpu_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gpu_search.Location = new System.Drawing.Point(214, 34);
            this.gpu_search.Name = "gpu_search";
            this.gpu_search.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gpu_search.Size = new System.Drawing.Size(143, 21);
            this.gpu_search.TabIndex = 1;
            this.gpu_search.TabStop = true;
            this.gpu_search.Text = "По названию gpu";
            this.gpu_search.UseVisualStyleBackColor = true;
            // 
            // cpu_search
            // 
            this.cpu_search.AutoSize = true;
            this.cpu_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cpu_search.Location = new System.Drawing.Point(17, 34);
            this.cpu_search.Name = "cpu_search";
            this.cpu_search.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cpu_search.Size = new System.Drawing.Size(174, 21);
            this.cpu_search.TabIndex = 0;
            this.cpu_search.TabStop = true;
            this.cpu_search.Text = "По имени процессора";
            this.cpu_search.UseVisualStyleBackColor = true;
            // 
            // SearchResult
            // 
            this.SearchResult.FormattingEnabled = true;
            this.SearchResult.ItemHeight = 16;
            this.SearchResult.Location = new System.Drawing.Point(60, 121);
            this.SearchResult.Name = "SearchResult";
            this.SearchResult.Size = new System.Drawing.Size(398, 244);
            this.SearchResult.TabIndex = 21;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 398);
            this.Controls.Add(this.SearchResult);
            this.Controls.Add(this.type_of_item);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Searchbox);
            this.Name = "Form4";
            this.Text = "Form4";
            this.type_of_item.ResumeLayout(false);
            this.type_of_item.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.TextBox Searchbox;
        private System.Windows.Forms.GroupBox type_of_item;
        private System.Windows.Forms.RadioButton all_search;
        private System.Windows.Forms.RadioButton gpu_search;
        private System.Windows.Forms.RadioButton cpu_search;
        private System.Windows.Forms.ListBox SearchResult;
    }
}