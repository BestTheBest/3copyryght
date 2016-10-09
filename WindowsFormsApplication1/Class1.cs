using System;
using System.Collections.Generic;
using System.Linq;
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
        List<cl> list = new List<cl>();

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
            f.dataGridView1.RowCount = list.Count;
            for (int i = 0; i < list.Count; i++)
            {
                cl obj1 = list[i];

                f.dataGridView1.Rows[i].Cells[0].Value = obj1.getpri();
                f.dataGridView1.Rows[i].Cells[1].Value = obj1.getima();
                f.dataGridView1.Rows[i].Cells[2].Value = obj1.getpob();
                f.dataGridView1.Rows[i].Cells[3].Value = obj1.getpos();
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