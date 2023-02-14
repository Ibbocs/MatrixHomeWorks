namespace BookCrud
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBox_authorName = new System.Windows.Forms.TextBox();
            this.txtBox_authorId = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBox_Surname = new System.Windows.Forms.TextBox();
            this.txtBox_publisherId = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBox_publisher = new System.Windows.Forms.TextBox();
            this.txtBox_sellerId = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBox_bookAmount = new System.Windows.Forms.TextBox();
            this.txtBox_bookName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBox_seller = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBox_sellAmount = new System.Windows.Forms.TextBox();
            this.txtBox_Pages = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBox_year = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBox_bookId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bttn_add = new System.Windows.Forms.Button();
            this.dataGridViewAll = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAll)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "New Book",
            "New Author",
            "New Publisher",
            "New Seller"});
            this.comboBox1.Location = new System.Drawing.Point(12, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(360, 28);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "Chose Operation";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtBox_authorName);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.txtBox_authorId);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtBox_Surname);
            this.panel1.Controls.Add(this.txtBox_publisherId);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtBox_publisher);
            this.panel1.Controls.Add(this.txtBox_sellerId);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtBox_bookAmount);
            this.panel1.Controls.Add(this.txtBox_bookName);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtBox_seller);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtBox_sellAmount);
            this.panel1.Controls.Add(this.txtBox_Pages);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtBox_year);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtBox_bookId);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 623);
            this.panel1.TabIndex = 1;
            // 
            // txtBox_authorName
            // 
            this.txtBox_authorName.Location = new System.Drawing.Point(187, 358);
            this.txtBox_authorName.Name = "txtBox_authorName";
            this.txtBox_authorName.Size = new System.Drawing.Size(185, 27);
            this.txtBox_authorName.TabIndex = 1;
            // 
            // txtBox_authorId
            // 
            this.txtBox_authorId.Location = new System.Drawing.Point(187, 94);
            this.txtBox_authorId.Name = "txtBox_authorId";
            this.txtBox_authorId.Size = new System.Drawing.Size(185, 27);
            this.txtBox_authorId.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(3, 358);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(178, 38);
            this.label14.TabIndex = 0;
            this.label14.Text = "Author Name";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 38);
            this.label2.TabIndex = 0;
            this.label2.Text = "Author Id";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBox_Surname
            // 
            this.txtBox_Surname.Location = new System.Drawing.Point(187, 402);
            this.txtBox_Surname.Name = "txtBox_Surname";
            this.txtBox_Surname.Size = new System.Drawing.Size(185, 27);
            this.txtBox_Surname.TabIndex = 1;
            // 
            // txtBox_publisherId
            // 
            this.txtBox_publisherId.Location = new System.Drawing.Point(187, 138);
            this.txtBox_publisherId.Name = "txtBox_publisherId";
            this.txtBox_publisherId.Size = new System.Drawing.Size(185, 27);
            this.txtBox_publisherId.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(3, 402);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(178, 38);
            this.label13.TabIndex = 0;
            this.label13.Text = "Surname";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(3, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 38);
            this.label3.TabIndex = 0;
            this.label3.Text = "Publisher Id";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBox_publisher
            // 
            this.txtBox_publisher.Location = new System.Drawing.Point(187, 446);
            this.txtBox_publisher.Name = "txtBox_publisher";
            this.txtBox_publisher.Size = new System.Drawing.Size(185, 27);
            this.txtBox_publisher.TabIndex = 1;
            // 
            // txtBox_sellerId
            // 
            this.txtBox_sellerId.Location = new System.Drawing.Point(187, 182);
            this.txtBox_sellerId.Name = "txtBox_sellerId";
            this.txtBox_sellerId.Size = new System.Drawing.Size(185, 27);
            this.txtBox_sellerId.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(3, 446);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(178, 38);
            this.label12.TabIndex = 0;
            this.label12.Text = "Publisher";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(3, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 38);
            this.label4.TabIndex = 0;
            this.label4.Text = "Seller Id";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBox_bookAmount
            // 
            this.txtBox_bookAmount.Location = new System.Drawing.Point(187, 490);
            this.txtBox_bookAmount.Name = "txtBox_bookAmount";
            this.txtBox_bookAmount.Size = new System.Drawing.Size(185, 27);
            this.txtBox_bookAmount.TabIndex = 1;
            // 
            // txtBox_bookName
            // 
            this.txtBox_bookName.Location = new System.Drawing.Point(187, 226);
            this.txtBox_bookName.Name = "txtBox_bookName";
            this.txtBox_bookName.Size = new System.Drawing.Size(185, 27);
            this.txtBox_bookName.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(3, 490);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(178, 38);
            this.label11.TabIndex = 0;
            this.label11.Text = "Book Amount";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(3, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 38);
            this.label5.TabIndex = 0;
            this.label5.Text = "Book Name";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBox_seller
            // 
            this.txtBox_seller.Location = new System.Drawing.Point(187, 534);
            this.txtBox_seller.Name = "txtBox_seller";
            this.txtBox_seller.Size = new System.Drawing.Size(185, 27);
            this.txtBox_seller.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(3, 534);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(178, 38);
            this.label10.TabIndex = 0;
            this.label10.Text = "Seller";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBox_sellAmount
            // 
            this.txtBox_sellAmount.Location = new System.Drawing.Point(187, 578);
            this.txtBox_sellAmount.Name = "txtBox_sellAmount";
            this.txtBox_sellAmount.Size = new System.Drawing.Size(185, 27);
            this.txtBox_sellAmount.TabIndex = 1;
            // 
            // txtBox_Pages
            // 
            this.txtBox_Pages.Location = new System.Drawing.Point(187, 270);
            this.txtBox_Pages.Name = "txtBox_Pages";
            this.txtBox_Pages.Size = new System.Drawing.Size(185, 27);
            this.txtBox_Pages.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(3, 578);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(178, 38);
            this.label9.TabIndex = 0;
            this.label9.Text = "Sell Amount";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(3, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(178, 38);
            this.label7.TabIndex = 0;
            this.label7.Text = "Pages";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBox_year
            // 
            this.txtBox_year.Location = new System.Drawing.Point(187, 314);
            this.txtBox_year.Name = "txtBox_year";
            this.txtBox_year.Size = new System.Drawing.Size(185, 27);
            this.txtBox_year.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(3, 314);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(178, 38);
            this.label8.TabIndex = 0;
            this.label8.Text = "Year";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBox_bookId
            // 
            this.txtBox_bookId.Location = new System.Drawing.Point(187, 50);
            this.txtBox_bookId.Name = "txtBox_bookId";
            this.txtBox_bookId.Size = new System.Drawing.Size(185, 27);
            this.txtBox_bookId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book Id";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bttn_add
            // 
            this.bttn_add.Dock = System.Windows.Forms.DockStyle.Top;
            this.bttn_add.Location = new System.Drawing.Point(386, 0);
            this.bttn_add.Name = "bttn_add";
            this.bttn_add.Size = new System.Drawing.Size(650, 88);
            this.bttn_add.TabIndex = 3;
            this.bttn_add.Text = "Add";
            this.bttn_add.UseVisualStyleBackColor = true;
            this.bttn_add.Click += new System.EventHandler(this.bttn_add_Click);
            // 
            // dataGridViewAll
            // 
            this.dataGridViewAll.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAll.Location = new System.Drawing.Point(386, 88);
            this.dataGridViewAll.Name = "dataGridViewAll";
            this.dataGridViewAll.RowHeadersWidth = 51;
            this.dataGridViewAll.RowTemplate.Height = 29;
            this.dataGridViewAll.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAll.Size = new System.Drawing.Size(650, 535);
            this.dataGridViewAll.TabIndex = 4;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 623);
            this.Controls.Add(this.dataGridViewAll);
            this.Controls.Add(this.bttn_add);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1054, 670);
            this.Name = "Form2";
            this.Text = "v";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAll)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtBox_authorName;
        private System.Windows.Forms.TextBox txtBox_authorId;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBox_Surname;
        private System.Windows.Forms.TextBox txtBox_publisherId;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBox_publisher;
        private System.Windows.Forms.TextBox txtBox_sellerId;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBox_bookAmount;
        private System.Windows.Forms.TextBox txtBox_bookName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBox_seller;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBox_sellAmount;
        private System.Windows.Forms.TextBox txtBox_Pages;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBox_year;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBox_bookId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttn_add;
        private System.Windows.Forms.DataGridView dataGridViewAll;
    }
}