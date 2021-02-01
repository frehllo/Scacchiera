using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriaClassi
{
    public abstract class Pezzo
    {
        private Cella posizione;
        public int Valore { get; private set; }
        public Colore Schieramento { get; private set; }
        public Cella Posizione
        {
            get => posizione; set
            {
                if (posizione != null)
                    posizione.Pezzo = null;
                posizione = value;
                posizione.Pezzo = this;
            }
        }
        public string Name => GetType().Name;
        public virtual string ShortName => Name.Substring(0, 3);
        protected Pezzo(int valore, Colore schieramento)
        {
            Valore = valore;
            Schieramento = schieramento;
        }

        public override string ToString()
        {
            return $"{Name} {Schieramento} in {Posizione}";
        }

        public virtual void Muovi(Cella nuovaPosizione)
        {
            if(nuovaPosizione.Occupata == true)
            {
                CellaOccupata();
            }
        }

        public void Errore()
        {
            throw new Exception($"Mossa non valida per {Name}");
        }

        public void CellaOccupata()
        {
            throw new Exception($"La cella è già occupata");
        }
    }
}
