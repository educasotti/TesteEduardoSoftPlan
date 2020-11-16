using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TesteEduardoSoftPlan.Controllers
{
    ///<Summary>
    /// Controller
    ///</Summary>
    [Route("[controller]")]
    [ApiController]
    public class TaxaJurosController : ControllerBase
    {
        ///<Summary>
        /// Return interest tax
        ///</Summary>
        ///
        [HttpGet]
        public string Get()
        {
            return "0,01";
        }
    }
}