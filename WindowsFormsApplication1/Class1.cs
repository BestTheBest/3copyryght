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
       private  string ima;
        private string pob;
        private string  pos;
        private double zar; 
        private string rez; 
        private string skarg; 

     public cl(string pas, string pri,string ima, string pob, string  pos, double zar , string rez , string skarg )
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
            this.pas = "BH233321";
            this.pri ="Акну";
            this.ima = "Пук";
            this.pob = "Аич";
            this.pos = "Директор";
            this.zar = 540;
            this.rez = "Відповідальний і тд і тп";
            this.skarg = "Немає";

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
        public void setzar(double  zar)
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
