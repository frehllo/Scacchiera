using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriaClassi
{
    class Pedone : Pezzo
    {
        public Pedone(Colore schieramento) : base(1, schieramento) { }
        public override void Muovi(Cella nuovaPosizione)
        {
            if (nuovaPosizione.Lettera == Posizione.Lettera)
            {
                int segno = Schieramento == Colore.Bianco ? +1 : -1;
                int start = Schieramento == Colore.Bianco ? 2 : 7;
            }
        }
    }
}
