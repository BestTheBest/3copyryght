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
        public int k = 0;
        cl f;
        List<cl> list = new List<cl>();
 
        public Form1()
        {
            InitializeComponent();
            f = new cl(this);
            comboBox4.SelectedIndex = 4;
            list.Sort();
        }

        private void відкритиToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            
        }
        public void serr()
        {
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter="Text Files |*.txt";

            saveFileDialog1.RestoreDirectory = true;


            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

              if((myStream =saveFileDialog1 .OpenFile()) != null)
                {

                    myStream.Close();
                }
            }
        }
        public void deserr()
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
            f.set();

            timer1.Enabled = true;
            timer2.Enabled = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void зберегтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4.SelectedIndex == 0)
            {
                textBox6.Text = "8540";
            }
            else
               if (comboBox4.SelectedIndex == 1)
            {
                textBox6.Text = "6440";
            }
            else
               if (comboBox4.SelectedIndex == 2)
            {
                textBox6.Text = "5340";
            }
            else
               if (comboBox4.SelectedIndex == 3)
            {
                textBox6.Text = "5280";
            }
            else
               if (comboBox4.SelectedIndex == 4)
            {
                textBox6.Text = "4240";
            }
            else
               if (comboBox4.SelectedIndex == 5)
            {
                textBox6.Text = "4200";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            f.get();
            f.get3();


            

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (checkBox1.Checked==true) {

                f.get41();
                label12.Text = "Фамілія";
            }

       
             if (checkBox2.Checked == true) { f.get42(); label12.Text = "І'мя"; }

           if (checkBox3.Checked == true) { f.get43(); label12.Text = "По-батькові"; }

          if (checkBox4.Checked == true) { f.get44(); label12.Text = "Номер паспорта"; }
             if (checkBox5.Checked == true) { f.get45(); label12.Text = "Посада"; }



            timer2.Enabled = false;
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
           
            
            
           


        
       
           
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true) {
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
            }


            timer2.Enabled = true;

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox1.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
            }

            timer2.Enabled = true;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                checkBox2.Checked = false;
                checkBox1.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
            }

            timer2.Enabled = true;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox1.Checked = false;
                checkBox5.Checked = false;
            }


            timer2.Enabled = true;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox1.Checked = false;
            }


            timer2.Enabled = true;
        }
        public void clean() {
            dataGridView2.Rows.Clear();
            f.e = 0;
        }
        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
          
            }

        private void comboBox1_ChangeUICues(object sender, UICuesEventArgs e)
        {



        }

        private void textBox9_ChangeUICues(object sender, UICuesEventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            clean();
            f.shear();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox9_TextChanged_1(object sender, EventArgs e)
        {
           
        }

        private void textBox9_TextChanged_2(object sender, EventArgs e)
        {
            clean();

            f.shear2();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {


        }

        private void зберегтиФалйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            serr();
        }
    }
}
