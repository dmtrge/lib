namespace lib
{
    partial class addform
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.namebox = new System.Windows.Forms.TextBox();
            this.authbox = new System.Windows.Forms.TextBox();
            this.year = new System.Windows.Forms.TextBox();
            this.idbookbox = new System.Windows.Forms.TextBox();
            this.notesbox = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cnclbtn = new System.Windows.Forms.Button();
            this.addbtn = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(639, 552);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.namebox);
            this.tabPage1.Controls.Add(this.authbox);
            this.tabPage1.Controls.Add(this.year);
            this.tabPage1.Controls.Add(this.idbookbox);
            this.tabPage1.Controls.Add(this.notesbox);
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Controls.Add(this.cnclbtn);
            this.tabPage1.Controls.Add(this.addbtn);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(631, 519);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // namebox
            // 
            this.namebox.Location = new System.Drawing.Point(232, 52);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(248, 26);
            this.namebox.TabIndex = 1;
            // 
            // authbox
            // 
            this.authbox.Location = new System.Drawing.Point(232, 102);
            this.authbox.Name = "authbox";
            this.authbox.Size = new System.Drawing.Size(248, 26);
            this.authbox.TabIndex = 2;
            // 
            // year
            // 
            this.year.Location = new System.Drawing.Point(232, 152);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(248, 26);
            this.year.TabIndex = 3;
            // 
            // idbookbox
            // 
            this.idbookbox.Location = new System.Drawing.Point(232, 197);
            this.idbookbox.Name = "idbookbox";
            this.idbookbox.Size = new System.Drawing.Size(248, 26);
            this.idbookbox.TabIndex = 4;
            // 
            // notesbox
            // 
            this.notesbox.Location = new System.Drawing.Point(232, 254);
            this.notesbox.Name = "notesbox";
            this.notesbox.Size = new System.Drawing.Size(248, 26);
            this.notesbox.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(320, 317);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // cnclbtn
            // 
            this.cnclbtn.Location = new System.Drawing.Point(506, 432);
            this.cnclbtn.Name = "cnclbtn";
            this.cnclbtn.Size = new System.Drawing.Size(79, 47);
            this.cnclbtn.TabIndex = 4;
            this.cnclbtn.Text = "Отмена";
            this.cnclbtn.UseVisualStyleBackColor = true;
            // 
            // addbtn
            // 
            this.addbtn.Location = new System.Drawing.Point(320, 432);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(101, 37);
            this.addbtn.TabIndex = 3;
            this.addbtn.Text = "Добавить";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(631, 519);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // addform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 790);
            this.Controls.Add(this.tabControl1);
            this.Name = "addform";
            this.Text = "addform";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button cnclbtn;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox namebox;
        private System.Windows.Forms.TextBox authbox;
        private System.Windows.Forms.TextBox year;
        private System.Windows.Forms.TextBox idbookbox;
        private System.Windows.Forms.TextBox notesbox;
    }
}