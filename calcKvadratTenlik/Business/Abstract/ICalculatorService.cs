using calcKvadratTenlik.Business.Concrete.Utilities;
using calcKvadratTenlik.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace calcKvadratTenlik.Business.Abstract
{
    public interface ICalculatorService
    {
        DataResult Calculator(RequestObject requestObject);
        double CalculatorD(RequestObject requestObject);
    }
}
