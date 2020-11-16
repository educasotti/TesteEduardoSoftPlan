using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TesteEduardoSoftPlan.Services;

namespace TesteEduardoSoftPlan.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CalculaJurosController : ControllerBase
    {
        protected readonly InterestService _interestService = new InterestService();
        private IWebHostEnvironment _hostEnvironment;

        public CalculaJurosController(IWebHostEnvironment env)
        {
            _hostEnvironment = env;
        }
        [HttpGet]
        public async Task<string> Get(double valorinicial, int meses)
        {
            var interest = await _interestService.GetInterest("https://localhost:44332/taxajuros");
            return _interestService.Calc(interest, valorinicial, meses);
        }
    }
}