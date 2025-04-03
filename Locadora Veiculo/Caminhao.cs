using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora_Veiculo
{
    public class Caminhão : Veiculo
    {
        public override decimal CalcularAluguel(int dias)
        {
            return dias * ValorAluguelDia * (1.2m);
        }
    }
}
