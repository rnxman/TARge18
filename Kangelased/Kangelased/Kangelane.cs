using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kangelased
{
    class Kangelane
    {
        private string _Nimi;
        private string _Asukoht;

        public Kangelane(string Nimi, string Asukoht)
        {
            this.Nimi = Nimi;
            this.Asukoht = Asukoht;
        }

        public string Nimi
        {
            get { return _Nimi; }
            set
            {
                _Nimi = value;
            }
        }

        public string Asukoht { get => _Asukoht;  set => _Asukoht = value; }
        public int Päästa(int Ohustatud)
        {
            return (int)Math.Round(Ohustatud * 0.95, 0);
        }

        public override string ToString()
        {
            return Nimi + " kaitseb " + Asukoht;
        }
    }
}
