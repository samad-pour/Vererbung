namespace Vererbung
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            var pkw = new PKW("ferrari", 300, 2);
            pkw.insassen = 9;
            pkw.bezeichnung = "riesen porsche";
            pkw.geschwindigkeit = 240;

            var fahrzeug = new Fahrzeug();
            fahrzeug.bezeichnung = "ein fahrzeug";
            fahrzeug.geschwindigkeit = 240;

            var lkw = new Lkw(5);
        }
    }

    class Fahrzeug
    {
        public string bezeichnung;
        public int geschwindigkeit;
        public Fahrzeug()
        {
            bezeichnung = "(leer)";
            geschwindigkeit = 0;
        }
        public Fahrzeug(string b, int g)
        {
            bezeichnung = b;
            geschwindigkeit = g;
        }
        public override string ToString()
        {
            return "Typ: " + GetType() + "\nBezeichnung: "
            + bezeichnung + "\n" + "Geschwindigkeit: "
            + geschwindigkeit + "\n\n";
        }
    }

    class Lkw : Fahrzeug
    {
        public int Laenge { get; set; }

        public Lkw(int laenge) : base()
        {
            Laenge = laenge;
        }
    }

    class PKW : Fahrzeug
    {
        public int insassen;
        public PKW()
        {
            insassen = 0;
        }
        public PKW(string b, int g, int i) : base(b, g)
        {
            insassen = i;
        }
    }


}