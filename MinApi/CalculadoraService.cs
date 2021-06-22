using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinApi
{
    public class CalculadoraService : ICalculadoraService
    {
        public Result ResultadoCalculadora { get; set; } = new Result();
        public async Task<Result> CalcularRentabilidade(Params parametros)
        {
            ResultadoCalculadora.ValorInvestidoInicial = parametros.ValorInvestido;
            ResultadoCalculadora.TotalFinalPeriodo = parametros.ValorInvestido;

            var tempoInvestimentoEmMeses = (parametros.AnoLimite - DateTime.Now.Year) * 12;

            var data = await Task.FromResult(CalcularRentabilidadeRecursivamente(parametros, tempoInvestimentoEmMeses, 0));
            data.AporteTotal += parametros.ValorInvestido;

            return data;
        }

        private Result CalcularRentabilidadeRecursivamente(Params parametros, int tempoInvestimentoEmMeses, int mesAtual)
        {
            var mes = new Mes();
            var dividendo = Convert.ToDecimal(ResultadoCalculadora.TotalFinalPeriodo / 100 * parametros.RentabilidadeAnual);

            mes.ValorFinal = ResultadoCalculadora.TotalFinalPeriodo;
            mes.MesAno = DateTime.Now.AddMonths(mesAtual);
            mes.DividendosMes = dividendo;

            if (parametros.ReinvestirDividendos)
            {
                ResultadoCalculadora.TotalFinalPeriodo += mes.DividendosMes;
            }

            ResultadoCalculadora.TotalDividendos += mes.DividendosMes;

            if (!(mesAtual == 0))
            { 
                mes.ValorFinal += parametros.AporteMensal;
                ResultadoCalculadora.AporteTotal += parametros.AporteMensal;
                ResultadoCalculadora.TotalFinalPeriodo += parametros.AporteMensal;
            }

            ResultadoCalculadora.ResultadoMensal.Add(mes);

            if (mesAtual == tempoInvestimentoEmMeses)
            {
                ResultadoCalculadora.ValorDividendoMensalFinal = mes.DividendosMes;
                return ResultadoCalculadora;
            }

            return CalcularRentabilidadeRecursivamente(parametros, tempoInvestimentoEmMeses, ++mesAtual);
        }
    }
}
