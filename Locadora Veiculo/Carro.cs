using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora_Veiculo
{
    public class Carro : Veiculo
    {
        public override decimal CalcularAluguel(int dias)
        {
            decimal total = dias * ValorAluguelDia;
            return total;
        }
    }
}
