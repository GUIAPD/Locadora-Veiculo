﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora_Veiculo
{
    public interface IVeiculo
    {
        public decimal CalcularAluguel(int dias);
    }
}
