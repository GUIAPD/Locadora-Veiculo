using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora_Veiculo
{
    public class Veiculo : IVeiculo
    {
        public virtual decimal CalcularAluguel(int dias)
        {
            Convert.ToDecimal(dias);
            return ValorAluguelDia * dias;
        }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public int Ano { get; set; }
        public decimal ValorAluguelDia { get; set; }
        public int Dias { get; set; }
        public int Numpedido { get; set; }
    }
}
