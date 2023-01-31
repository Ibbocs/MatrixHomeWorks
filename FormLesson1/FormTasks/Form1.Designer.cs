namespace FormTasks
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.comBxColour = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lstBox_Task2 = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bttnTask2 = new System.Windows.Forms.Button();
            this.richTxtBox_Task2 = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comBxColour);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 585);
            this.panel1.TabIndex = 0;
            // 
            // comBxColour
            // 
            this.comBxColour.Dock = System.Windows.Forms.DockStyle.Top;
            this.comBxColour.FormattingEnabled = true;
            this.comBxColour.Items.AddRange(new object[] {
            "Default"});
            this.comBxColour.Location = new System.Drawing.Point(0, 300);
            this.comBxColour.Name = "comBxColour";
            this.comBxColour.Size = new System.Drawing.Size(272, 39);
            this.comBxColour.TabIndex = 1;
            this.comBxColour.Tag = "";
            this.comBxColour.Text = "Default";
            this.comBxColour.SelectedIndexChanged += new System.EventHandler(this.comBxColour_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 63);
            this.label2.TabIndex = 3;
            this.label2.Text = "Other Themes";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.Location = new System.Drawing.Point(0, 160);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(272, 77);
            this.button2.TabIndex = 2;
            this.button2.Text = "Light-Dark Mode";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 160);
            this.label1.TabIndex = 1;
            this.label1.Text = "Change Back-Colour";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstBox_Task2
            // 
            this.lstBox_Task2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lstBox_Task2.FormattingEnabled = true;
            this.lstBox_Task2.ItemHeight = 31;
            this.lstBox_Task2.Location = new System.Drawing.Point(0, 240);
            this.lstBox_Task2.Name = "lstBox_Task2";
            this.lstBox_Task2.Size = new System.Drawing.Size(612, 345);
            this.lstBox_Task2.TabIndex = 2;
            this.lstBox_Task2.Click += new System.EventHandler(this.lstBox_Task2_Click);
            this.lstBox_Task2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstBox_Task2_MouseClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bttnTask2);
            this.panel2.Controls.Add(this.richTxtBox_Task2);
            this.panel2.Controls.Add(this.lstBox_Task2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(272, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(612, 585);
            this.panel2.TabIndex = 3;
            // 
            // bttnTask2
            // 
            this.bttnTask2.Dock = System.Windows.Forms.DockStyle.Top;
            this.bttnTask2.Location = new System.Drawing.Point(0, 160);
            this.bttnTask2.Name = "bttnTask2";
            this.bttnTask2.Size = new System.Drawing.Size(612, 77);
            this.bttnTask2.TabIndex = 4;
            this.bttnTask2.Text = "Add Text";
            this.bttnTask2.UseVisualStyleBackColor = true;
            this.bttnTask2.Click += new System.EventHandler(this.bttnTask2_Click);
            // 
            // richTxtBox_Task2
            // 
            this.richTxtBox_Task2.Dock = System.Windows.Forms.DockStyle.Top;
            this.richTxtBox_Task2.Location = new System.Drawing.Point(0, 0);
            this.richTxtBox_Task2.Name = "richTxtBox_Task2";
            this.richTxtBox_Task2.Size = new System.Drawing.Size(612, 160);
            this.richTxtBox_Task2.TabIndex = 4;
            this.richTxtBox_Task2.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 585);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comBxColour;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstBox_Task2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox richTxtBox_Task2;
        private System.Windows.Forms.Button bttnTask2;
    }
}
