using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelmanagement
{
    public class client
    {
        public string nume="non";
        public string prenume="non";
        public string datedecontact = "empty";
        public string datecarddecredit = "empty";
        public client() { }
        public client(string pnume, string pprenume, string pdatedecontact, string pdatecarddecredit) 
        { 
            this.nume = pnume;
            this.prenume = pprenume;
            this.datedecontact = pdatedecontact;
            this.datecarddecredit = pdatecarddecredit;
        }

        public string printClient()
        {
            string r = this.nume + " , " + this.prenume;
            r += " , " + this.datedecontact + " , " + this.datecarddecredit;
          
            return r;
        }
    }
}
