﻿using System;

namespace LibreriaClassi
{
    public sealed class Cella
    {
        public bool Occupata
        {
            get
            {
                if (Pezzo != null)
                {
                    return true;
                }
                else
                    return false;
            }
        }
        public char Lettera { get; private set; }
        public int Numero { get; private set; }
        public Pezzo Pezzo { get; set; }

        public Cella(int x, char y)
        {
            this.Lettera = y;
            this.Numero = x;
        }
        public Colore Colore
        {
            get
            {
                bool numeroPari = Numero % 2 == 0;
                bool letteraPari = (Lettera - 'A') % 2 == 0;
                if (numeroPari == letteraPari)
                    return Colore.Nero;
                return Colore.Bianco;
            }
        }
        public override string ToString()
        {
            return $"{Lettera}{Numero}";
        }
    }
}
