using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    [Serializable]

    class cl
    {

        private string pas;
        private string pri;
        private string ima;
        private string pob;
        private string pos;
        private double zar;
        private string rez;
        private string skarg;
        private Form1 f;
        private Form1 form1;
        private int n;
        public int e=0;
    public    List<cl> list = new List<cl>();

        public cl(string pas, string pri, string ima, string pob, string pos, double zar, string rez, string skarg)
        {
            this.pas = pas;
            this.pri = pri;
            this.ima = ima;
            this.pob = pob;
            this.pos = pos;
            this.zar = zar;
            this.rez = rez;
            this.skarg = skarg;
        }


        public cl()
        {

        }

        public void set()
        {
            cl obj = new cl();
            obj.setpas(f.textBox1.Text);
            obj.setpri(f.textBox2.Text);
            obj.setima(f.textBox3.Text);
            obj.setpob(f.textBox4.Text);
            obj.setpos(f.comboBox4.Text);
            obj.setzar(Convert.ToDouble(f.textBox6.Text));
            obj.setrez(f.textBox7.Text);
            obj.setskarg(f.textBox8.Text);
            list.Add(obj);
        }

        public void get()
        {
            f.dataGridView1.RowCount = list.Count+1;
            for (int i = 0; i < list.Count; i++)
            {
                cl obj1 = list[i];

                f.dataGridView1.Rows[i].Cells[0].Value = obj1.getpri();
                f.dataGridView1.Rows[i].Cells[1].Value = obj1.getima();
                f.dataGridView1.Rows[i].Cells[2].Value = obj1.getpob();
                f.dataGridView1.Rows[i].Cells[3].Value = obj1.getpos();
            }
        }
        public void get3()
        {
            f.dataGridView3.RowCount = list.Count+1;
            for (int i = 0; i < list.Count; i++)
            {
                cl obj1 = list[i];

                f.dataGridView3.Rows[i].Cells[0].Value = obj1.getpri();
                f.dataGridView3.Rows[i].Cells[1].Value = obj1.getima();
                f.dataGridView3.Rows[i].Cells[2].Value = obj1.getpob();
                f.dataGridView3.Rows[i].Cells[3].Value = obj1.getzar();
                f.dataGridView3.Rows[i].Cells[4].Value = obj1.getzar() * 0.1;
                f.dataGridView3.Rows[i].Cells[5].Value = obj1.getzar() * 1.1;


            }

        }
        public void get41()
            {
       
            f.comboBox1.Items.Clear();
          f.  comboBox1.BeginUpdate();
           
            for (int i = 0; i < list.Count; i++)
            {

                int r=0;
                cl obj1 = list[i];

                if (i == 0) { f.comboBox1.Items.Add(obj1.getpri().ToString()); }
                if (i > 0)
                {
               
                    for (int k = 0; k < i; k++)
                    {
                        cl obj2 = list[k];
                        if (obj2.getpri().ToString() != obj1.getpri().ToString()) { r = 1;  } else { r = 0; k = i; }
                                
                    }
                    if (r == 1) { f.comboBox1.Items.Add(obj1.getpri().ToString()); }

                }
            }
          f.  comboBox1.EndUpdate();
        }
        public void get42()
        {

            f.comboBox1.Items.Clear();
            f.comboBox1.BeginUpdate();

            for (int i = 0; i < list.Count; i++)
            {

                int r = 0;
                cl obj1 = list[i];

                if (i == 0) { f.comboBox1.Items.Add(obj1.getima().ToString()); }
                if (i > 0)
                {

                    for (int k = 0; k < i; k++)
                    {
                        cl obj2 = list[k];
                        if (obj2.getima().ToString() != obj1.getima().ToString()) { r = 1; } else { r = 0; k = i; }

                    }
                    if (r == 1) { f.comboBox1.Items.Add(obj1.getima().ToString()); }

                }
            }
            f.comboBox1.EndUpdate();
        }
        public void get43()
        {

            f.comboBox1.Items.Clear();
            f.comboBox1.BeginUpdate();

            for (int i = 0; i < list.Count; i++)
            {

                int r = 0;
                cl obj1 = list[i];

                if (i == 0) { f.comboBox1.Items.Add(obj1.getpob().ToString()); }
                if (i > 0)
                {

                    for (int k = 0; k < i; k++)
                    {
                        cl obj2 = list[k];
                        if (obj2.getpob().ToString() != obj1.getpob().ToString()) { r = 1; } else { r = 0; k = i; }

                    }
                    if (r == 1) { f.comboBox1.Items.Add(obj1.getpob().ToString()); }

                }
            }
            f.comboBox1.EndUpdate();
        }
     public void get44()////
        {

            f.comboBox1.Items.Clear();
            f.comboBox1.BeginUpdate();

            for (int i = 0; i < list.Count; i++)
            {

                int r = 0;
                cl obj1 = list[i];

                if (i == 0) { f.comboBox1.Items.Add(obj1.getpas().ToString()); }
                if (i > 0)
                {

                    for (int k = 0; k < i; k++)
                    {
                        cl obj2 = list[k];
                        if (obj2.getpas().ToString() != obj1.getpas().ToString()) { r = 1; } else { r = 0; k = i; }

                    }
                    if (r == 1) { f.comboBox1.Items.Add(obj1.getpas ().ToString()); }

                }
            }
            f.comboBox1.EndUpdate();
        }
        public void get45()
        {

            f.comboBox1.Items.Clear();
            f.comboBox1.BeginUpdate();

            for (int i = 0; i < list.Count; i++)
            {

                int r = 0;
                cl obj1 = list[i];

                if (i == 0) { f.comboBox1.Items.Add(obj1.getpos().ToString()); }
                if (i > 0)
                {

                    for (int k = 0; k < i; k++)
                    {
                        cl obj2 = list[k];
                        if (obj2.getpos().ToString() != obj1.getpos().ToString()) { r = 1; } else { r = 0; k = i; }

                    }
                    if (r == 1) { f.comboBox1.Items.Add(obj1.getpos().ToString()); }

                }
            }
            f.comboBox1.EndUpdate();
        }
       
      

        public void get21()
        {
            
            f.dataGridView2.RowCount = list.Count+e;
            for (int i = 0; i < list.Count; i++)
            {
                cl obj1 = list[i];
              
                    if (f.comboBox1.SelectedItem.ToString() == obj1.getpri())
                    {


                        f.dataGridView2.Rows[e].Cells[0].Value = obj1.getpri();
                        f.dataGridView2.Rows[e].Cells[1].Value = obj1.getima();
                        f.dataGridView2.Rows[e].Cells[2].Value = obj1.getpob();
                        f.dataGridView2.Rows[e].Cells[4].Value = obj1.getpas();
                        f.dataGridView2.Rows[e].Cells[4].Value = obj1.getpos();
                        f.textBox12.Text = obj1.getrez();
                        f.textBox5.Text = obj1.getskarg();
                        e = e + 1;
                    }
                 
            }
        }
        public void get22()
        {

            f.dataGridView2.RowCount = list.Count + e;
            for (int i = 0; i < list.Count; i++)
            {
                cl obj1 = list[i];
               
                    if (f.comboBox1.SelectedItem.ToString() == obj1.getima())
                    {


                        f.dataGridView2.Rows[e].Cells[0].Value = obj1.getpri();
                        f.dataGridView2.Rows[e].Cells[1].Value = obj1.getima();
                        f.dataGridView2.Rows[e].Cells[2].Value = obj1.getpob();
                        f.dataGridView2.Rows[e].Cells[4].Value = obj1.getpas();
                        f.dataGridView2.Rows[e].Cells[4].Value = obj1.getpos();
                        f.textBox12.Text = obj1.getrez();
                        f.textBox5.Text = obj1.getskarg();
                        e = e + 1;
                    
                }
            }
        }
        public void get23()
        {

            f.dataGridView2.RowCount = list.Count + e;
            for (int i = 0; i < list.Count; i++)
            {
                cl obj1 = list[i];
             
                    if (f.comboBox1.SelectedItem.ToString() == obj1.getpob())
                    {


                        f.dataGridView2.Rows[e].Cells[0].Value = obj1.getpri();
                        f.dataGridView2.Rows[e].Cells[1].Value = obj1.getima();
                        f.dataGridView2.Rows[e].Cells[2].Value = obj1.getpob();
                        f.dataGridView2.Rows[e].Cells[4].Value = obj1.getpos();
                        f.dataGridView2.Rows[e].Cells[4].Value = obj1.getpas();
                        f.textBox12.Text = obj1.getrez();
                        f.textBox5.Text = obj1.getskarg();
                        e = e + 1;
                  
                }
            }
        }
        public void get24()
        {

            f.dataGridView2.RowCount = list.Count + e;
            for (int i = 0; i < list.Count; i++)
            {
                cl obj1 = list[i];
             
                    if (f.comboBox1.SelectedItem.ToString() == obj1.getpas())
                    {


                        f.dataGridView2.Rows[e].Cells[0].Value = obj1.getpri();
                        f.dataGridView2.Rows[e].Cells[1].Value = obj1.getima();
                        f.dataGridView2.Rows[e].Cells[2].Value = obj1.getpob();
                        f.dataGridView2.Rows[e].Cells[3].Value = obj1.getpas();
                        f.dataGridView2.Rows[e].Cells[4].Value = obj1.getpos();
                        f.textBox12.Text = obj1.getrez();
                        f.textBox5.Text = obj1.getskarg();
                        e = e + 1;
                   
                }
            }
        }
        public void get25()
        {

            f.dataGridView2.RowCount = list.Count + e;
            for (int i = 0; i < list.Count; i++)
            {
                cl obj1 = list[i];
              
                    if (f.comboBox1.SelectedItem.ToString() == obj1.getpos())
                    {


                        f.dataGridView2.Rows[e].Cells[0].Value = obj1.getpri();
                        f.dataGridView2.Rows[e].Cells[1].Value = obj1.getima();
                        f.dataGridView2.Rows[e].Cells[2].Value = obj1.getpob();
                        f.dataGridView2.Rows[e].Cells[3].Value = obj1.getpas();
                        f.dataGridView2.Rows[e].Cells[4].Value = obj1.getpos();
                        f.textBox12.Text = obj1.getrez();
                        f.textBox5.Text = obj1.getskarg();
                        e = e + 1;
                    }
                  
                
            }
        }
        public void get212()
        {

            f.dataGridView2.RowCount = list.Count + e;
            for (int i = 0; i < list.Count; i++)
            {
                cl obj1 = list[i];
                if ( obj1.getpri().Contains(f.textBox9.Text))
                {
                    f.dataGridView2.Rows[e].Cells[0].Value = obj1.getpri();
                    f.dataGridView2.Rows[e].Cells[1].Value = obj1.getima();
                    f.dataGridView2.Rows[e].Cells[2].Value = obj1.getpob();
                    f.dataGridView2.Rows[e].Cells[4].Value = obj1.getpas();
                    f.dataGridView2.Rows[e].Cells[4].Value = obj1.getpos();
                    f.textBox12.Text = obj1.getrez();
                    f.textBox5.Text = obj1.getskarg();
                    e = e + 1;

                }
            }
        }
        public void get222()
        {

            f.dataGridView2.RowCount = list.Count + e;
            for (int i = 0; i < list.Count; i++)
            {
                cl obj1 = list[i];
                if (obj1.getima().Contains(f.textBox9.Text))
                {
                    f.dataGridView2.Rows[e].Cells[0].Value = obj1.getpri();
                    f.dataGridView2.Rows[e].Cells[1].Value = obj1.getima();
                    f.dataGridView2.Rows[e].Cells[2].Value = obj1.getpob();
                    f.dataGridView2.Rows[e].Cells[4].Value = obj1.getpas();
                    f.dataGridView2.Rows[e].Cells[4].Value = obj1.getpos();
                    f.textBox12.Text = obj1.getrez();
                    f.textBox5.Text = obj1.getskarg();
                    e = e + 1;
                }
                

            }
        }
        public void get232()
        {

            f.dataGridView2.RowCount = list.Count + e;
            for (int i = 0; i < list.Count; i++)
            {
                cl obj1 = list[i];
                if (  obj1.getpob().Contains(f.textBox9.Text))
                {
                    f.dataGridView2.Rows[e].Cells[0].Value = obj1.getpri();
                    f.dataGridView2.Rows[e].Cells[1].Value = obj1.getima();
                    f.dataGridView2.Rows[e].Cells[2].Value = obj1.getpob();
                    f.dataGridView2.Rows[e].Cells[4].Value = obj1.getpos();
                    f.dataGridView2.Rows[e].Cells[4].Value = obj1.getpas();
                    f.textBox12.Text = obj1.getrez();
                    f.textBox5.Text = obj1.getskarg();
                    e = e + 1;

                }
             
            }
        }
        public void get242()
        {

            f.dataGridView2.RowCount = list.Count + e;
            for (int i = 0; i < list.Count; i++)
            {
                cl obj1 = list[i];
                if ( obj1.getpas().Contains(f.textBox9.Text))
                {
                    f.dataGridView2.Rows[e].Cells[0].Value = obj1.getpri();
                    f.dataGridView2.Rows[e].Cells[1].Value = obj1.getima();
                    f.dataGridView2.Rows[e].Cells[2].Value = obj1.getpob();
                    f.dataGridView2.Rows[e].Cells[3].Value = obj1.getpas();
                    f.dataGridView2.Rows[e].Cells[4].Value = obj1.getpos();
                    f.textBox12.Text = obj1.getrez();
                    f.textBox5.Text = obj1.getskarg();
                    e = e + 1;
                }
               
            }
        }
        public void get252()
        {

            f.dataGridView2.RowCount = list.Count + e;
            for (int i = 0; i < list.Count; i++)
            {
                cl obj1 = list[i];
                if (  obj1.getpos().Contains(f.textBox9.Text))
                {
                    f.dataGridView2.Rows[e].Cells[0].Value = obj1.getpri();
                    f.dataGridView2.Rows[e].Cells[1].Value = obj1.getima();
                    f.dataGridView2.Rows[e].Cells[2].Value = obj1.getpob();
                    f.dataGridView2.Rows[e].Cells[3].Value = obj1.getpas();
                    f.dataGridView2.Rows[e].Cells[4].Value = obj1.getpos();
                    f.textBox12.Text = obj1.getrez();
                    f.textBox5.Text = obj1.getskarg();
                    e = e + 1;


                }
              
            }
        }
        public void shear2() {
            if (f.label12.Text == "Фамілія") {

                get212();

            }
            if (f.label12.Text == "І'мя")
            {

                get222();

            }
            if (f.label12.Text == "По-батькові")
            {

                get232();

            }
            if (f.label12.Text == "Номер паспорта")
            {

                get242();

            }
            if (f.label12.Text == "Посада")
            {

                get252();

            }
         

            }


             public void shear()
        {
            if (f.label12.Text == "Фамілія")
            {

                get21();

            }
            if (f.label12.Text == "І'мя")
            {

                get22();

            }
            if (f.label12.Text == "По-батькові")
            {

                get23();

            }
            if (f.label12.Text == "Номер паспорта")
            {

                get24();

            }
            if (f.label12.Text == "Посада")
            {

                get25();

            }
           



        }

        public cl(Form1 ff)
        {
            this.form1 = ff;
            f = ff;
        }

        public void setpas(string pas)
        {
            this.pas = pas;
        }

        public void setpri(string pri)
        {
            this.pri = pri;
        }
        public void setima(string ima)
        {
            this.ima = ima;
        }
        public void setpob(string pob)
        {
            this.pob = pob;
        }
        public void setpos(string pos)
        {
            this.pos = pos;
        }
        public void setzar(double zar)
        {
            this.zar = zar;
        }
        public void setrez(string rez)
        {
            this.rez = rez;
        }
        public void setskarg(string skarg)
        {
            this.skarg = skarg;
        }
        public void setn(int n)
        {
            this.n = n;
        }
        public int getn()
        {
            return this.n;
        }
        public string getpas()
        {
            return this.pas;
        }
        public string getpri()
        {
            return this.pri;
        }

        public string getima()
        {
            return this.ima;
        }

        public string getpob()
        {
            return this.pob;
        }

        public string getpos()
        {
            return this.pos;
        }

        public double getzar()
        {
            return this.zar;
        }

        public string getrez()
        {
            return this.rez;
        }

        public string getskarg()
        {
            return this.skarg;
        }

     
    }
}