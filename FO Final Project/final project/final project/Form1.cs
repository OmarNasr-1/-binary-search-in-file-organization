using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final_project
{
    public partial class Form1 : Form
    {
        //public string path;

        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)          //create_btn
        {
            if (String.IsNullOrEmpty(textBox1.Text))  //you should name the file
                MessageBox.Show("Please enter the file name", "Error");
            else
            {
                FileS.path = Environment.CurrentDirectory + @"\..\..\..\" + textBox1.Text + ".txt"; //creat file.txt in the current directory of the program          
                
                    if (!File.Exists(FileS.path)) // if the file not exist will creat it else show the file is already exist
                    {
                        File.CreateText(FileS.path).Close();

                        MessageBox.Show("file has been creatred sucessfully","Done");// file has created 
                        FileS.fname = textBox1.Text;
                        textBox1.Clear();
                    }
                    else
                    {
                        MessageBox.Show("file already exists","Warnning");//there is same name of this file 
                    }
            }
        }

        private void button2_Click(object sender, EventArgs e)          //Insert_btn
        {
           
            if (String.IsNullOrEmpty(FileS.path))//if you dont make a file show warninng message 
                MessageBox.Show("Please create a file!","Notice");
            else
            {
                new Form2().Show();//will open new form to insert some data in the file
            }
            //this.Hide();
        }
        private void button3_Click(object sender, EventArgs e)          //Display_btn
        {
            BinaryReader br = new BinaryReader(File.Open(FileS.path, FileMode.Open, FileAccess.Read));
            int length = (int)br.BaseStream.Length / FileS.rec_size;
            if (length != 0)         //File is not Empty
            {
                label1.Text = FileS.fname;
                label1.Visible = true;
                try
                {
                    br.BaseStream.Seek(FileS.counter, SeekOrigin.Begin);

                    richTextBox1.Text = "ID: " + br.ReadInt32().ToString() + "\n\n" + 
                        "Book Title: " + br.ReadString() + "\n\n" + "Language: " + br.ReadString() +
                        "\n\n" + "Category: " + br.ReadString() + "\n\n" + "Price: " + br.ReadDouble().ToString();
                    //MessageBox.Show("test");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }

                if ((FileS.counter / FileS.rec_size) >= (length-1)) // End of file then, Start at the Begin
                {
                    FileS.counter = 0;
                    //br.Close();
                }
                else
                    FileS.counter += FileS.rec_size;
            }
            else MessageBox.Show("File is empty", "warning");
            br.Close();
        }

        private void button4_Click(object sender, EventArgs e)          //Delete_btn
        {
            FileS.path = Environment.CurrentDirectory + @"\..\..\..\" + textBox1.Text + ".txt";

            try
            {
                if (File.Exists(FileS.path))
                {
                    File.Delete(FileS.path);
                    MessageBox.Show("File has been deleted","Done");
                    textBox1.Clear();
                    FileS.path = null;
                    FileS.fname = null;
                    label1.Text =null;
                    richTextBox1.Clear();
                }
                else
                    MessageBox.Show("There is no file with this name","Notice");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void button5_Click(object sender, EventArgs e)          //Exit_btn
        {
            Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            FileS.path = null;
            FileS.fname = null;
            label1.Text = null;
            richTextBox1.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}



/*
CreatedBy:-
    Amr Ashraf Ahmed            119000688                   Class-17
    Amr Mohamed Abdelfatah      119000528                   Class-17
    Omar Nasr Elsayed           119000024                   Claas-7
 ahmed attia elshamy            119000416                   c1aas-7
*/