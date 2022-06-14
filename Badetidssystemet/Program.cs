using System;

namespace Badetidssystemet
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Badetidsperiode badetid = new Badetidsperiode()
                {
                    _Type = "Morgen dukkert",
                    _Ugedag = new DayOfWeek(),
                    _Starttidspunkt = new DateTime(2022, 06, 16),
                    _Sluttidspunkt = new DateTime(2023, 06, 15)
                };
                Kreds kredsen = new Kreds()
                {
                    _Id = "123",
                    _Navn = "RubberKredsen",
                    _Adresse = "Rubberkredsensvej",
                    _Antaldeltagere = 5
                };
                Kreds k1 = new Kreds() { _Id = "999", _Navn = "JamenDogsen", _Adresse = "JamenDogsensVej", _Antaldeltagere = 999 };
                Kreds k2 = new Kreds() { _Id = "666", _Navn = "JamenHalløjsa", _Adresse = "JamenHalløjsaVej", _Antaldeltagere = 666 };
                Kreds k3 = new Kreds() { _Id = "123", _Navn = "GutenHeuteLeute", _Adresse = "GutenHeuteLeuteVej", _Antaldeltagere = 123 };
                Kreds k4 = new Kreds() { _Id = "420", _Navn = "EjOka", _Adresse = "EjOkaysensVej", _Antaldeltagere = 420 };

                Console.WriteLine(kredsen);
                Console.WriteLine();
                badetid.TilføjKreds(k1);
                badetid.TilføjKreds(k2);
                badetid.TilføjKreds(k3);
                badetid.TilføjKreds(k4);
                Console.WriteLine();
                Console.WriteLine(badetid);
                Console.WriteLine();
                badetid.SletKreds(k4);
                Console.WriteLine(badetid);
            }
            catch (ArgumentException e)
            {

                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
