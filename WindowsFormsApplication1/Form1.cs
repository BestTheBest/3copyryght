using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace WindowsFormsApplication1
{
    [Serializable]
    public partial class Form1 : Form
    {
        List<cl> listCL1;

        public Form1()
        {
            InitializeComponent();
        }


        private void відкритиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {


            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" &&
               textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "")
            {
                try
                {
                
                    listCL1.Add(new cl(textBox1.Text, textBox2.Text, textBox6.Text, textBox5.Text, comboBox4.Text, System.Convert.ToDouble(textBox3.Text), textBox7.Text, textBox8.Text));
                    string message = "Працівника  добавлено";
                    string caption = "Повідомлення";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show(message, caption, buttons);
                }
                catch
                {
                    string message = "Данны введено не коректно";
                    string caption = "Помилка добавлення";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show(message, caption, buttons);
                }
            }
            else
            {
                string message = "Введіть дані в усі поля";
                string caption = "Помилка добавлення";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons);
            }




        }

       private void Form1_Load(object sender, EventArgs e)
        {

              listCL1 = new List<cl>();
              string path = Path.GetDirectoryName(Application.StartupPath.ToString()) + "\\addresses.txt";
              System.IO.FileStream fs = new System.IO.FileStream(path, System.IO.FileMode.Open, System.IO.FileAccess.Read, System.IO.FileShare.Read);
               System.Runtime.Serialization.Formatters.Binary.BinaryFormatter bf = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
              listCL1 = (List<cl>)bf.Deserialize(fs);
               fs.Close();  

            
           

        }




        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
              string path = Path.GetDirectoryName(Application.StartupPath.ToString()) + "\\addresses.txt";
               FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
               System.Runtime.Serialization.Formatters.Binary.BinaryFormatter bf = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
               bf.Serialize(fs, listCL1);
               fs.Close();


        }


        private void comboBox4_ChangeUICues(object sender, UICuesEventArgs e)
        {
          


        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4.SelectedIndex == 0)
            {
                textBox3.Text = "540";
            } else
                if (comboBox4.SelectedIndex == 1)
            {
                textBox3.Text = "440";
            }
            else
                if (comboBox4.SelectedIndex == 2)
            {
                textBox3.Text = "340";
            }
            else
                if (comboBox4.SelectedIndex == 3)
            {
                textBox3.Text = "280";
            }
            else
                if (comboBox4.SelectedIndex == 4)
            {
                textBox3.Text = "240";
            }
            else
                if (comboBox4.SelectedIndex == 4)
            {
                textBox3.Text = "200";
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
