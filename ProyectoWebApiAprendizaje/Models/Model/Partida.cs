using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Model
{
    public class Partida:BaseModel
    {
        public Decimal stackInicial { get; set; }
        public int Jugadores { get; set; }
        public DateTime Fecha { get; set; }
    }
}
