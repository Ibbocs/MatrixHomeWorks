using BookCrud.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookCrud
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void CloseTxtBox()
        {
            this.txtBox_bookId.Enabled = false;
            this.txtBox_authorId.Enabled = false;
            this.txtBox_publisherId.Enabled = false;
            this.txtBox_sellerId.Enabled = false;
            this.txtBox_bookName.Enabled = false;
            this.txtBox_Pages.Enabled = false;
            this.txtBox_year.Enabled = false;
            this.txtBox_authorName.Enabled = false;
            this.txtBox_Surname.Enabled = false;
            this.txtBox_publisher.Enabled = false;
            this.txtBox_bookAmount.Enabled = false;
            this.txtBox_seller.Enabled = false;
            this.txtBox_sellAmount.Enabled = false;
        }

        private  MyCrud getBook()
        {
          
            int.TryParse(txtBox_bookId.Text, out int bookId);
            int.TryParse(txtBox_authorId.Text, out int authorId);
            int.TryParse(txtBox_publisherId.Text, out int publisherId);
            int.TryParse(txtBox_sellerId.Text, out int sellerId);
            int.TryParse(txtBox_Pages.Text, out int pages);
            int.TryParse(txtBox_bookAmount.Text, out int bookAmount);
            int.TryParse(txtBox_sellAmount.Text, out int sellerAmount);
            

            string bookName = txtBox_bookName.Text,
                year = txtBox_year.Text,
                authorName = txtBox_authorName.Text,
                authorSurname = txtBox_Surname.Text,
                publisher = txtBox_publisher.Text,
                seller = txtBox_seller.Text;

            return new MyCrud(bookId, authorId, publisherId, sellerId, bookName, pages, year, authorName,
                            authorSurname, publisher, bookAmount, seller, sellerAmount);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
            CloseTxtBox();
            MyCrud myCrud = getBook();
            dataGridViewAll.DataSource = myCrud.list("sellectAll");
           

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "New Author")
            {
                CloseTxtBox();
                txtBox_authorName.Enabled = true;
                txtBox_Surname.Enabled = true;
            }
            else if (comboBox1.Text == "New Book")
            {
                CloseTxtBox();
                //this.txtBox_bookId.Enabled = true;
                this.txtBox_bookName.Enabled = true;
                this.txtBox_Pages.Enabled = true;
                this.txtBox_year.Enabled = true;
                this.txtBox_authorId.Enabled = true;
            }
            else if (comboBox1.Text == "New Publisher")
            {
                CloseTxtBox();
            }
            else if (comboBox1.Text == "New Seller")
            {
                CloseTxtBox();
            }
            else
            {
                CloseTxtBox();
            }
        }

        private void bttn_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text == "New Author")
                {
                    MyCrud myCrud = getBook();
                    myCrud.Add("insertAuthor");
                    dataGridViewAll.DataSource = myCrud.list("sellectAll");

                }
                else if (comboBox1.Text == "New Book")
                {

                    MyCrud myCrud = getBook();
                    myCrud.Add("insertBook");
                    dataGridViewAll.DataSource = myCrud.list("sellectAll");
                }
                else if (comboBox1.Text == "New Publisher")
                {
                    CloseTxtBox();
                }
                else if (comboBox1.Text == "New Seller")
                {
                    CloseTxtBox();
                }
                else
                {
                    MessageBox.Show("Please Chose Any Operation Type");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }  
        }
    }
}
