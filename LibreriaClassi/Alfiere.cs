using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriaClassi
{
    public class Alfiere : Pezzo
    {
        public Alfiere(Colore schieramento ) : base (3, schieramento) { }
        public override void Muovi(Cella nuovaPosizione)
        {
            base.Muovi(nuovaPosizione);
            if (Math.Abs(nuovaPosizione.Lettera - Posizione.Lettera) ==
               Math.Abs(nuovaPosizione.Numero - Posizione.Numero))
            {
                Posizione = nuovaPosizione;
            }
            else
                Errore();
        }
    }
}
