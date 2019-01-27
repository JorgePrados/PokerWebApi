using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Model
{
    public class Jugada : BaseModel
    {
        public Partida Partida { get; set; }
        public DateTime Fecha { get; set; }

        public Carta CartaFlop1 { get; set; }
        public Carta CartaFlop2 { get; set; }
        public Carta CartaFlop3 { get; set; }

        public Carta CartaTurn { get; set; }
        public Carta CartaRiver { get; set; }

        public decimal BotePreFlop { get; set; }
        public decimal BoteFlop { get; set; }
        public decimal BoteTurn { get; set; }
        public decimal BoteRiver { get; set; }

        public int JugadoresRestantesPreFlop { get; set; }
        public int JugadoresRestantesFlop { get; set; }
        public int JugadoresRestantesTurn { get; set; }
        public int JugadoresRestantesRiver { get; set; }

    }
}
