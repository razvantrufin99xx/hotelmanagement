using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelmanagement
{
    public class camera
    {
        public string numarul="";
        public string etaj="0";
        public int nrpaturi = 0;
        public bool balcon = false;
        public float suprafata = 1.0f;
        public bool ocupata = false;
        public bool rezervata = false;
        public DateTime ocupatadeladata = DateTime.Now;
        public DateTime ocupatapanaladata = DateTime.Now;
        public int numaruldeziledeocupare = 0;
        public int numaruldeziledecandstaneocupata = 0;
        public float pretulpezi = 1.0f;
        public float pretulpeora = 1.0f;


        public camera() { }

        public camera(string pnumarul, string petaj, int pnrpaturi, bool pbalcon, float psuprafata) 
        { 
        this.numarul = pnumarul;
            this.etaj = petaj;
            this.nrpaturi = pnrpaturi;
            this.balcon = pbalcon;
            this.suprafata = psuprafata;
        }

        public bool seteazapretulpezi(float x)
        {
            this.pretulpezi = x;
            return true;
        }
        public bool seteazapretulpeora(float x)
        {
            this.pretulpeora = x;
            return true;
        }
        public bool seteazaocupatadeladata(DateTime x)
        {
            this.ocupatadeladata = x;
            return true;
        }
        public bool seteazaocupatapanaladata(DateTime x)
        {
            this.ocupatapanaladata = x;
            return true;
        }
        public bool seteazanumaruldeziledeocupare(int x)
        {
            this.numaruldeziledeocupare = x;
            return true;
        }
        public bool seteazanumaruldeziledecandstaneocupata(int x)
        {
            this.numaruldeziledecandstaneocupata = x;
            return true;
        }
        public bool seteazarezervata(bool x)
        {
            this.rezervata = x;
            return true;
        }
        public bool seteazaocupata(bool x)
        {
            this.ocupata = x;
            return true;
        }
        public string printCamera()
        {
            string r = this.numarul + " , " + this.etaj;
            r += " , " + this.nrpaturi.ToString() + " , " + this.balcon.ToString();
            r += " , " + this.suprafata.ToString() + " , " + this.ocupata.ToString();
            r += " , " + this.rezervata.ToString() + " , " + this.ocupatadeladata.ToString();
            r += " , " + this.ocupatapanaladata.ToString() + " , " + this.numaruldeziledeocupare.ToString();
            r += " , " + this.pretulpezi.ToString() + " , " + this.pretulpeora.ToString();
            return r;
        }
    }
}
