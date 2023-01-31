using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormTasks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Task1
            //Verilen renglerden istifadechi sechdiyi formun rengi hemin renge cevrilsin. 
            List<String> themesColour = new List<string>() 
            {
                "Blue",
                "Yellow",
                "Green",
                "Red",
                "Purple"
            };

            foreach (var item in themesColour)
            {
                comBxColour.Items.Add(item);
            }


            //Task2
            //Textboxa vergul ile adlar daxil edecem.Onlari sechib listboxa daxil edin.
            lstBox_Task2.Text = null;

            //Task3
            //Hemen listboxda hansisa ada click etsem o listboxdan ad silinsin.


        }

        bool checkTheme = false;
        private void button2_Click(object sender, EventArgs e)
        {
            if (checkTheme==false)
            {
                //Form1 frm1 = new Form1();
                //frm1.BackColor = Color.Black;
                this.ForeColor= Color.White;
                this.BackColor = Color.Black;
                button2.BackColor = Color.Black;
                checkTheme = true;
                comBxColour.SelectedIndex= 0;
            }
            else
            {
                this.ForeColor = Color.Black;
                this.BackColor = Color.White;
                button2.BackColor = Color.White;
                checkTheme = false;
                comBxColour.SelectedIndex = 0;
            }
        }

        private void comBxColour_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ForeColor = Color.White;

            if (comBxColour.Text=="Blue")
            {
                this.BackColor = Color.Blue;
            }
            else if (comBxColour.Text == "Yellow")
            {
                this.BackColor = Color.Yellow;
            }
            else if (comBxColour.Text == "Red")
            {
                this.BackColor = Color.Red;
            }
            else if (comBxColour.Text == "Purple")
            {
                this.BackColor = Color.Purple;
            }
            else if (comBxColour.Text == "Green")
            {
                this.BackColor = Color.Green;
            }
            else
            {
                this.BackColor = Color.White;
                this.ForeColor = Color.Black;
            }
        }

        private void bttnTask2_Click(object sender, EventArgs e)
        {
            string text;
            if (richTxtBox_Task2.Text != "")
            {
                text = richTxtBox_Task2.Text;

                foreach (var item in text.Trim().Split(","))
                {
                    lstBox_Task2.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("Please, Enter Text");
            }
        }

        private void lstBox_Task2_Click(object sender, EventArgs e)
        {
            //// string a = lstBox_Task2.SelectedIndex.ToString();
            //object text = lstBox_Task2.SelectedItem;
            //MessageBox.Show(text);
            List<string> list = new List<string>();

            foreach (var item in lstBox_Task2.Items.ToString())
            {
                list.Add(item.ToString());
            }
            //MessageBox.Show(list.ToString());


        }

        private void lstBox_Task2_MouseClick(object sender, MouseEventArgs e)
        {
            //bu kodu men yazmamisam, men burda tapsiriga uygun listbox methodunu eger varsa tapa bilmedim internetde ve
            //istedim ki, algoritm qurum hansi ki, listbox texlerini bir liste atacaq, sizin secdiyiniz texti bir string
            //fild'e atacaq ve sonra secili texti listden sili, teze listi list boxa yazacaq. Amma secdiyiniz texdi
            //bir string filde'atdira bilmedim, listbox'u da liste(char olaraq atirdi). Click eventinde yazdiqlarimi
            //gore bilersiz

            int index = lstBox_Task2.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                lstBox_Task2.Items.RemoveAt(index);
            }

            //int index = lstBox_Task2.SelectedIndex;
            //lstBox_Task2.Items.Remove(index);
        }
    }
}
