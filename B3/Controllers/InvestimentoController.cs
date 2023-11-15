using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;
using B3.Entidades;
using B3.Interfaces;
using B3.Services;
using Microsoft.Extensions.Logging;

namespace B3.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*", SupportsCredentials = true)]
    public class InvestimentoController : Controller
    {
        private readonly ILogger<InvestimentoController> _logger;
        private readonly IInvestimentoServices _investimentoServices;

        public InvestimentoController()
        {
        }

        public InvestimentoController(ILogger<InvestimentoController> logger, InvestimentoServices investimentoServices)
        {
            _logger = logger;
            _investimentoServices = investimentoServices;
        }

        [HttpPost]
        [Route("{controller}/CalcularInvestimento")]
        public InvestidorEntity CalcularInvestimento(InvestidorEntity dadosInvestidor)
        {
            var investimentoServices = new InvestimentoServices();
            return investimentoServices.CalcularInvestimento(dadosInvestidor);
        }
    }
}
