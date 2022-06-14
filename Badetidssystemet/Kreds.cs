using System;
using System.Collections.Generic;
using System.Text;

namespace Badetidssystemet
{
    class Kreds
    {
        public int Antaldeltagere;
        public string _Id { get; set; }
        public string _Navn { get; set; }
        public string _Adresse { get; set; }
        public int _Antaldeltagere 
        {
            get 
            { 
                if (Antaldeltagere <= 0)
                {
                    throw new ArgumentException($"Antal deltagere var 0 eller færre");
                }
                else
                {
                    return Antaldeltagere;
                }
            }
            set 
            {
                Antaldeltagere = value;
            } 
        }

        public Kreds(string Id, string Navn, string Adresse, int Antaldeltagere)
        {
            _Id = Id;
            _Navn = Navn;
            _Adresse = Adresse;
            _Antaldeltagere = Antaldeltagere;
        }

        public Kreds()
        {

        }

        public override string ToString()
        {
            return $"Id : {_Id}" + "\n" + $"Navn :{_Navn}" + "\n" + $"Adresse : {_Adresse}" + "\n" + $"Antal deltagere : {_Antaldeltagere}";
        }
    }
}
