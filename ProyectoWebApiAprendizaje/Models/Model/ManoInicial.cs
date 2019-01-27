using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Model
{
    public class ManoInicial : BaseModel
    {
        public Jugada Jugada { get; set; }
        public Carta Carta1 { get; set; }
        public Carta Carta2 { get; set; }
    }
}
