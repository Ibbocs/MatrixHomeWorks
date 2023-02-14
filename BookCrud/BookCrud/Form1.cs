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
    public partial class Form1 : Form
    {
        //private BookADO db = new BookADO();

        public Form1()
        {
            InitializeComponent();
            txtBox_bookId.Focus();

            //Book bk = new Book();
            //bk.BookSellect(1, db);
        }



        //private Book getBook()
        //{
        //    int bookId = Convert.ToInt32(txtBox_bookId.Text),
        //        authorId = Convert.ToInt32(txtBox_authorId.Text),
        //        publisherId = Convert.ToInt32(txtBox_publisherId.Text),
        //        sellerId = Convert.ToInt32(txtBox_sellerId.Text),
        //        pages = Convert.ToInt32(txtBox_Pages.Text),
        //        bookAmount = Convert.ToInt32(txtBox_bookAmount.Text),
        //        sellerAmount = Convert.ToInt32(txtBox_sellAmount.Text);

        //    string bookName = txtBox_bookName.Text,
        //        year = txtBox_year.Text,
        //        authorName = txtBox_authorName.Text,
        //        authorSurname = txtBox_Surname.Text,
        //        publisher = txtBox_publisher.Text,
        //        seller = txtBox_seller.Text;

        //    return new Book(bookId,authorId,publisherId,sellerId,bookName,pages,year,authorName,
        //                    authorSurname,publisher,bookAmount,seller,sellerAmount);

        //}

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // dataGridViewAll.DataSource = MyCrud.list("sellectAll");
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //db.Disconnect();
        }

        private void bttn_add_Click(object sender, EventArgs e)
        {
            //Book bk = getBook();
            //bk.AddStudent(db);
        }
    }
}
