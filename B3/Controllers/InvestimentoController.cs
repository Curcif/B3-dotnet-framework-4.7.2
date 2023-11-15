using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Results;
using B3.Entidades;
using B3.Interfaces;
using B3.Services;
using Microsoft.Extensions.Logging;

namespace B3.Controllers
{
    [RoutePrefix("Investimento")]
    public class InvestimentoController : ApiController
    {
        private readonly IInvestimentoServices _investimentoServices;

        public InvestimentoController(IInvestimentoServices investimentoServices)
        {
            _investimentoServices = investimentoServices;
        }

        [Route("CalcularInvestimento")]
        [HttpPost()]
        public IHttpActionResult CalcularInvestimento([FromBody]InvestidorEntity dadosInvestidor)
        {
            return Ok(_investimentoServices.CalcularInvestimento(dadosInvestidor));
        }
    }
}
