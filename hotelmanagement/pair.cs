using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelmanagement
{
    public class pair
    {
        public int a;
        public int b;
        public pair(int idcamera, int idclient)
        {
            this.a = idcamera;
            this.b = idclient;    
        }
        public pair() { }
        public string printPair()
        {
            string r = this.a.ToString() + " , " + this.b.ToString();
           
            return r;
        }
    }
}
