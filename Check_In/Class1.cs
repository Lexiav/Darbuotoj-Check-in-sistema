using System;

namespace Check_In
{
    public class Darbuotojas
    {
        public string vardas { get; set; }
        public string pavarde { get; set; }
        public string asmensKodas { get; set; }
        public string pareigos { get; set; }
        public double atlyginimas { get; set; }
        public double neuzmoketuValanduSkaicius { get; set; }
        public DateTime darbaPradejo { get; set; }
        private bool dirba;

        public Darbuotojas(string Vardas, string Pavarde, string AsmensKodas, string Pareigos, double Atlyginimas)
        {
            vardas = Vardas;
            pavarde = Pavarde;
            asmensKodas = AsmensKodas;
            pareigos = Pareigos;
            atlyginimas = Atlyginimas;
            neuzmoketuValanduSkaicius = 0;
        }

        public void pradetiDarba()
        {
            darbaPradejo = DateTime.Now;
            dirba = true;
        }

        public void baigtiDarba()
        {
            neuzmoketuValanduSkaicius = neuzmoketuValanduSkaicius + (DateTime.Now - darbaPradejo).TotalHours;
            dirba = false;
        }

        public bool arDirba()
        {
            return dirba;
        }

        public double ismoketiAtlyginima()
        {
            double pinigai = neuzmoketuValanduSkaicius * atlyginimas;
            neuzmoketuValanduSkaicius = 0;
            return pinigai;
        }
    }
}
