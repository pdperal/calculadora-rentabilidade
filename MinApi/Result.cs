using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinApi
{
    public class Result
    {
        public decimal ValorInvestidoInicial { get; set; }
        public decimal AporteTotal { get; set; }
        public decimal ValorDividendoMensalFinal { get; set; }
        public decimal TotalDividendos { get; set; }
        public decimal TotalFinalPeriodo { get; set; }
        public List<Mes> ResultadoMensal { get; set; } = new List<Mes>();
    }
    
    public class Mes
    {
        public DateTime MesAno { get; set; }
        public decimal DividendosMes { get; set; }
        public decimal ValorFinal { get; set; }
    }
}
