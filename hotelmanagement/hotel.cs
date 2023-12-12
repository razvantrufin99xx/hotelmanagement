using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelmanagement
{
    public class hotel
    {
        public string denumire="";
        public string adresa="";

        public List<camera> camere= new List<camera>();
        public List<client> clienti = new List<client> ();
        public List<rezervare> rezervari = new List<rezervare>();
        public List<pair> perechicamereclienti = new List<pair> ();

        public bool adaugaCamera(camera x)
        { 
            camere.Add(x);
            return true;
        }
        public bool adaugaClient(client x)
        {
            clienti.Add(x);
            return true;
        }

        public bool adaugaRezervare(rezervare x)
        {
            rezervari.Add(x);
            return true;
        }
        public bool adaugaPerecheCameraClient(pair x)
        {
            perechicamereclienti.Add(x);
            return true;
        }


        public hotel() { }
        public hotel(string denumire, string adresa)
        {
            this.denumire = denumire;
            this.adresa = adresa;
        }
        public string printHotel()
        {
            string r = this.denumire + " , " + this.adresa;

            return r;
        }

    }
}
