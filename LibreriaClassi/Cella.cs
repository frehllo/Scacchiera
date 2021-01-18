using System;

namespace LibreriaClassi
{
    public class Cella
    {
        public char Y { get; private set; }
        public int X { get; private set; }
        public Colore Colore { get; private set; }
        public Pezzo Pezzo { get; set; }

        public Cella(int x, char y, Pezzo p)
        {
            this.Y = y;
            this.X = x;
            this.Pezzo = p;
        }
    }
}
