using calcKvadratTenlik.Business.Abstract;
using calcKvadratTenlik.Business.Concrete.Messages;
using calcKvadratTenlik.Business.Concrete.Utilities;
using calcKvadratTenlik.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace calcKvadratTenlik.Business
{
    public class CalculatorManager : ICalculatorService
    {

        public double D { get; set; }
        public double X1 { get; set; }
        public double X2 { get; set; }


        DataResult ICalculatorService.Calculator(RequestObject requestObject)
        {

            List<double> xValues = new List<double>();
            D = CalculatorD(requestObject);


            if (D > 0)
            {
                if (requestObject.A == 0)
                {
                    return new DataResult(Messages.MsgZeroExp);
                }
                X1 = (-requestObject.B + Math.Sqrt(D)) / (2 * requestObject.A);
                X2 = (-requestObject.B - Math.Sqrt(D)) / (2 * requestObject.A);

                xValues.Add(X1);
                xValues.Add(X2);

                return new DataResult(xValues);
            }
            else if (D < 0)
            {
                return new DataResult(Messages.MsgNoReplay);

                X1 = float.NaN;
                X2 = float.NaN;

                xValues.Add(X1);
                xValues.Add(X2);
            }
            else
            {
                if (requestObject.A==0)
                {
                    return new DataResult(Messages.MsgZeroExp);
                }
                X1 = (-requestObject.B) / (2 * requestObject.A);

                xValues.Add(X1);
                return new DataResult(xValues);

            }
            return new DataResult( Messages.MsgErorData);


        }
        public double CalculatorD(RequestObject requestObject)
        {
            return requestObject.B * requestObject.B - 4 * requestObject.A * requestObject.C;
        }
    }

}





