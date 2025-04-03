using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora_Veiculo
{
    public class Moto : Veiculo
    {
        public override decimal CalcularAluguel(int dias)
        {
            return base.CalcularAluguel(dias) * 0.9m;
        }
    }
}
