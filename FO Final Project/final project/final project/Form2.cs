using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace final_project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            flName_lbl.Visible = true;
            flName_lbl.Text = FileS.fname;
        }
        private void button1_Click(object sender, EventArgs e)          //Save_btn
        {
            BinaryWriter bw = new BinaryWriter(File.Open(FileS.path, FileMode.Open, FileAccess.Write));
            
                //will open the file you recentlly make and write in it the data you will enter 

            int length = (int)bw.BaseStream.Length;

            if (length != 0)    //file is not empy
            {
                bw.BaseStream.Seek(length, SeekOrigin.Begin);

                init(bw);

                length += FileS.rec_size;// update number of records 

            }
            else    //file is empty
            {
                init(bw);
                length += FileS.rec_size;
            }
            MessageBox.Show("Data is saved successfully","Done");//after insert data clear the form2
           ISBN_txtBox.Clear();
            title_txtBox.Clear();
            lang_txtBox.Clear();
            cat_txtBox.Clear();
            price_txtBox.Clear();
            bw.Close();
            
        }
        public void init(BinaryWriter binaryF) 
        {
            binaryF.Write(int.Parse(ISBN_txtBox.Text));

            title_txtBox.Text = title_txtBox.Text.PadRight(20);
            binaryF.Write(title_txtBox.Text.Substring(0, 20));

            lang_txtBox.Text = lang_txtBox.Text.PadRight(15);
            binaryF.Write(lang_txtBox.Text.Substring(0, 15));

            cat_txtBox.Text = cat_txtBox.Text.PadRight(10);
            binaryF.Write(cat_txtBox.Text.Substring(0, 10));

            binaryF.Write(double.Parse(price_txtBox.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ID_txtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void price_txtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void price_txtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ISBN_txtBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

/*
CreatedBy:-
    Amr Ashraf Ahmed            119000688                   Cl-17
    Amr Mohamed Abdelfatah      119000528                   Cl-17
    Omar Nasr Elsayed           119000024                   Cl-7
 * ahmed attia elshamy            119000416                   c1aas-7
*/

