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
using System.Collections;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        cl f;
        List<cl> list = new List<cl>();
        public Form1()
        {
            InitializeComponent();
            f = new cl(this);
        }

        private void відкритиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Вітя цей код паше но ти маєш зробити шоб відкривав де файл знаходиться. Тіпа відкрити файл і шукаєш де він
          /*  FileStream fs = new FileStream("zavod.dat", FileMode.Open);

            BinaryFormatter formatter = new BinaryFormatter();

            list = (List<cl>)formatter.Deserialize(fs);*/
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
            f.set();
            f.get();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "+")
            {
                button1.Text = "-";
                comboBox2.Visible = true;
                textBox10.Visible = true;
                comboBox2.Enabled = true;
                textBox10.Enabled = true;
                button2.Visible = true;
                button2.Enabled = true;
            }
            else
            {
                button1.Text = "+";
                comboBox2.Visible = false;
                textBox10.Visible = false;
                comboBox3.Enabled = false;
                textBox10.Enabled = false;
                button2.Visible = false;
                button2.Enabled = false;
                button2.Text = "+";
                comboBox3.Visible = false;
                textBox11.Visible = false;
                comboBox3.Enabled = false;
                textBox11.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "+")
            {
                button2.Text = "-";
                comboBox3.Visible = true;
                textBox11.Visible = true;
                comboBox3.Enabled = true;
                textBox11.Enabled = true;
            }
            else
            {
                button2.Text = "+";
                comboBox3.Visible = false;
                textBox11.Visible = false;
                comboBox3.Enabled = false;
                textBox11.Enabled = false;
            }
        }

        private void зберегтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (var fStream = new FileStream("zavod.dat", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                formatter.Serialize(fStream, list);
            }
        }
    }
}
