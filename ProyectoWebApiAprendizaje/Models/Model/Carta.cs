using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models.Model
{
    public class Carta
    {
        [Key]
        public string Codigo { get; set; }
        public int Numero { get; set; }
        public string Palo { get; set; }
    }
}
