using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelmanagement
{
    public class rezervare
    {
        public int id;
        public int idclient;
        public DateTime datarezervazii  = DateTime.Now;

        public rezervare() { }
        public rezervare(int pid, int pidclient, DateTime pdatarezervarii)
        {
            this.id = pid;
            this.idclient = pidclient;
            this.datarezervazii = pdatarezervarii;

        }
        public string printRezervare()
        {
            string r = this.id.ToString() + " , " + this.idclient.ToString() + "," + this.datarezervazii.ToString();

            return r;
        }
    }
}
