using Microsoft.AspNetCore.Mvc;
using System.Transactions;

namespace dtcoreLr.Controllers
{
    public class DemoController : Controller
    {
        private readonly ISingletonService _singletonService;
        private readonly IScopeService _scopeService;
        private readonly ITransientService _transientService;
        public DemoController(ISingletonService singletonService,
                              IScopedService scopedService,
                              ITransientService transientService)
        {
            _singletonService = singletonService;
            _scopeService = scopedService;
            _transientService = transientService;

            
        }
    }
}
