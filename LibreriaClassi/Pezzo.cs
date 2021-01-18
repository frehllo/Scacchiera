using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriaClassi
{
    public class Pezzo
    {
        public int Valore { get; private set; }
        public Colore Colore { get; private set; }
        public Cella Cella { get; set; }

        public Pezzo(int v, Colore co, Cella ce)
        {
            this.Valore = v;
            this.Colore = co;
            this.Cella = ce;
        }

        public string ToString()
        {
            return $"{Valore} {Colore} sta in {Cella}";
        }

        public void Spostati(Cella c)
        {

        }
    }
}
