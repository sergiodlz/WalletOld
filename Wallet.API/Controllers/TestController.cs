using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using Wallet.DATA;

namespace Wallet.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private ILogger<TestController> _logger;
        private WalletContext _context;

        public TestController(ILogger<TestController> logger, WalletContext context)
        {
            _logger = logger;
            _context = context;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            var values = new string[] { "value1", "value2" };
            _logger.LogInformation("{values}", values);
            return values;
        }
    }
}