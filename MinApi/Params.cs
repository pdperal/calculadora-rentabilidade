using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinApi
{
    public class Params
    {
        private decimal _rentabilidade;
        public decimal ValorInvestido { get; set; }
        public decimal RentabilidadeAnual
        {
            get => _rentabilidade / 12;
            set => _rentabilidade = value;
        }
        public bool ReinvestirDividendos { get; set; }
        public decimal AporteMensal { get; set; }
        public int AnoLimite { get; set; }
    }
}
