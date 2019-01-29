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
        public Decimal ProbabilidadContra1 { get; set; }
        public Decimal ProbabilidadContra2 { get; set; }
        public Decimal ProbabilidadContra3 { get; set; }
        public Decimal ProbabilidadContra4 { get; set; }
        public Decimal ProbabilidadContra5 { get; set; }
        public Decimal ProbabilidadContra6 { get; set; }
        public Decimal ProbabilidadContra7 { get; set; }
        public Decimal ProbabilidadContra8 { get; set; }
        public Decimal ProbabilidadContra9 { get; set; }
        public Decimal ProbabilidadContra10 { get; set; }
    }
}
