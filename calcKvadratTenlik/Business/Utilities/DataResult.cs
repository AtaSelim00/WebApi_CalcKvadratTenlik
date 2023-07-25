using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace calcKvadratTenlik.Business.Concrete.Utilities
{

    public class DataResult
    {
        public List<double> Data { get; }
        public string Message { get; }

        public DataResult(List<double> data)
        {
            Data = data;
        }

        public DataResult(string message)
        {
            Message = message;
        }

    }

}
