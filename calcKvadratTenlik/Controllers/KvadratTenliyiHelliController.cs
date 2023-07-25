using calcKvadratTenlik.Business.Abstract;
using calcKvadratTenlik.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace calcKvadratTenlik.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KvadratTenliyiHelliController : ControllerBase
    {

        private ICalculatorService _calculator;

        public KvadratTenliyiHelliController(ICalculatorService calculator)
        {
            this._calculator = calculator;
        }

        [HttpPost]
        [Route("[action]")]
        public IActionResult Calculator([FromBody] RequestObject request)
        {


            double D = _calculator.CalculatorD(request);
            var result = _calculator.Calculator(request);


            if (D > 0 || D == 0)
            {
                if (request.A == 0)
                {
                    return BadRequest(result.Message);
                }
                return Ok(result.Data);
            }
            else
            {
                return BadRequest(result.Message);
            }



        }
    }
}
