using System;
using System.Collections.Generic;
using System.Text;

namespace Badetidssystemet
{
    class Badetidsperiode
    {
        Dictionary<string, Kreds> Kredser;

        public DateTime Starttidspunkt;
        public DateTime Sluttidspunkt;
        public string Type;
        public string _Type 
        {
            get 
            {
                if (Type.Length < 4)
                {
                    throw new ArgumentException("Type length was less than 4 letters");
                }
                else
                {
                    return Type;
                }
            }
            set { Type = value; } 
        }
        public DayOfWeek _Ugedag { get; set; }
        public DateTime _Starttidspunkt 
        { get 
            {
                if (Starttidspunkt > Sluttidspunkt)
                {
                    throw new ArgumentException($"Starttidspunkt var senere end sluttidspunkt");
                }
                else
                {
                    return Starttidspunkt;
                }
            }
            set { Starttidspunkt = value; }
        }
        public DateTime _Sluttidspunkt 
        { 
            get 
            {
                if (Sluttidspunkt < Starttidspunkt)
                {
                    throw new ArgumentException($"Sluttidspunkt var før starttidspunkt");
                }
                else
                {
                    return Sluttidspunkt;
                }
            } 
            set { Sluttidspunkt = value; } 
        }
        public Badetidsperiode(string Type, DayOfWeek Ugedag, DateTime Starttidspunkt, DateTime Sluttidspunkt)
        {
            _Type = Type;
            _Ugedag = Ugedag;
            _Starttidspunkt = Starttidspunkt;
            _Sluttidspunkt = Sluttidspunkt;
        }

        public Badetidsperiode()
        {
            Kredser = new Dictionary<string, Kreds>();
        }
        public void TilføjKreds(Kreds kreds)
        {
            Kredser.Add(kreds._Id, kreds);
        }
        public void SletKreds(Kreds kreds)
        {
            Kredser.Remove(kreds._Id);
        }


        public override string ToString()
        {
            string tekst = "";
            foreach (var item in Kredser)
            {
                tekst = tekst + "\n" + item.ToString();
            }
            return $"Type: {_Type}, Ugedag: {_Ugedag}, Starttidspunkt: {_Starttidspunkt}, Sluttidspunkt: {_Sluttidspunkt}" + "\n" + tekst;
        }

    }
}
