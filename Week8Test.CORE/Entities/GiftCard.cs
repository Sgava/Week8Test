﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8Test.CORE.Entities
{
    public class GiftCard
    {
        public int Id { get; set; } 
        public string Mittente { get; set; }    
        public string Destinatario { get; set; }
        public DateTime DataDiScadenza {  get; set; }
        public double Importo { get; set; } 
        public string Messaggio { get; set; }

        public string ToShortString()
        {
            return $"{Destinatario} -- {Importo}€";
        }

        public string ToLongString()
        {
            return $"From {Mittente} to {Destinatario} - {Importo}€ - da usare entro il {DataDiScadenza.ToShortDateString()}\n  - {Messaggio}";
        }
    }
}
