namespace hotelmanagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public hotel hcsb = new hotel("Hotel Continental Sibiu", "Sibiu, Romania, Piata Unirii numarul 1");

        public bool runHCSB(ref hotel h) {

            //adauga camera
            h.adaugaCamera(new camera("A1", "parter", 1, false, 25));
            h.adaugaCamera(new camera("A2", "parter", 1, false, 25));
            h.adaugaCamera(new camera("A3", "parter", 1, false, 25));
            h.adaugaCamera(new camera("A4", "parter", 1, false, 25));
            h.adaugaCamera(new camera("A5", "parter", 1, false, 25));
            h.adaugaCamera(new camera("A6", "parter", 1, false, 25));
            h.adaugaCamera(new camera("A7", "parter", 1, false, 25));
            //adauga client
            h.adaugaClient(new client("necunoscut", "mirel","sibiu, romania strada nr bloc etaj scara apartament","cod card bancar banca dataemiterii dataexpirarii sumadeplata"));
            h.adaugaClient(new client("necunoscut", "ionel", "sibiu, romania strada nr bloc etaj scara apartament", "cod card bancar banca dataemiterii dataexpirarii sumadeplata"));
            h.adaugaClient(new client("necunoscut", "costel", "sibiu, romania strada nr bloc etaj scara apartament", "cod card bancar banca dataemiterii dataexpirarii sumadeplata"));
            h.adaugaClient(new client("necunoscut", "nicu", "sibiu, romania strada nr bloc etaj scara apartament", "cod card bancar banca dataemiterii dataexpirarii sumadeplata"));
            h.adaugaClient(new client("necunoscut", "tavi", "sibiu, romania strada nr bloc etaj scara apartament", "cod card bancar banca dataemiterii dataexpirarii sumadeplata"));
            h.adaugaClient(new client("necunoscut", "alex", "sibiu, romania strada nr bloc etaj scara apartament", "cod card bancar banca dataemiterii dataexpirarii sumadeplata"));
            h.adaugaClient(new client("necunoscut", "gheorghe", "sibiu, romania strada nr bloc etaj scara apartament", "cod card bancar banca dataemiterii dataexpirarii sumadeplata"));
            h.adaugaClient(new client("necunoscut", "ion", "sibiu, romania strada nr bloc etaj scara apartament", "cod card bancar banca dataemiterii dataexpirarii sumadeplata"));
            h.adaugaClient(new client("necunoscut", "george", "sibiu, romania strada nr bloc etaj scara apartament", "cod card bancar banca dataemiterii dataexpirarii sumadeplata"));
            h.adaugaClient(new client("necunoscut", "bob", "sibiu, romania strada nr bloc etaj scara apartament", "cod card bancar banca dataemiterii dataexpirarii sumadeplata"));
            //adauga rezervare online sau telefonic
            h.adaugaRezervare(new rezervare(1, 0, DateTime.Now));
            h.adaugaRezervare(new rezervare(2, 1, DateTime.Now));
            h.adaugaRezervare(new rezervare(3, 2, DateTime.Now));
            h.adaugaRezervare(new rezervare(4, 3, DateTime.Now));
            h.adaugaRezervare(new rezervare(5, 4, DateTime.Now));
            h.adaugaRezervare(new rezervare(6, 5, DateTime.Now));
            h.adaugaRezervare(new rezervare(7, 6, DateTime.Now));
            //pune client in camera
            h.adaugaPerecheCameraClient(new pair(0, 0));
            h.adaugaPerecheCameraClient(new pair(1, 1));
            h.adaugaPerecheCameraClient(new pair(2, 2));
            h.adaugaPerecheCameraClient(new pair(3, 3));

            return true;
        }
        public bool printNewLine(ref TextBox t, int countNewLines)
        {
            for (int i = 0; i < countNewLines; i++)
            {
                t.Text += "\r\n";
            }
            return true; 
        }  
        
        public bool printAll(ref hotel h, ref TextBox t)
        {
            printNewLine(ref this.textBox1, 3);
            t.Text += h.printHotel();
            printNewLine(ref this.textBox1, 2);
            for (int i = 0; i < h.camere.Count; i++)
            {
                t.Text += h.camere[i].printCamera();
                printNewLine(ref this.textBox1, 1);
            }
            printNewLine(ref this.textBox1, 2);
            for (int i = 0; i < h.clienti.Count; i++)
            {
                t.Text += h.clienti[i].printClient();
                printNewLine(ref this.textBox1, 1);
            }
            printNewLine(ref this.textBox1, 2);
            for (int i = 0; i < h.rezervari.Count; i++)
            {
                t.Text += h.rezervari[i].printRezervare();
                printNewLine(ref this.textBox1, 1);
            }
            printNewLine(ref this.textBox1, 2);
            for (int i = 0; i < h.perechicamereclienti.Count; i++)
            {
                t.Text += h.perechicamereclienti[i].printPair();
                printNewLine(ref this.textBox1, 1);
                t.Text += h.camere[h.perechicamereclienti[i].a].printCamera();
                printNewLine(ref this.textBox1, 1);
                t.Text += h.clienti[h.perechicamereclienti[i].b].printClient();
                printNewLine(ref this.textBox1, 1);
            }
            printNewLine(ref this.textBox1, 2);


            return true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            runHCSB(ref hcsb);
            printAll(ref hcsb, ref textBox1);
        }
    }
}
