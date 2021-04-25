using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebApiEFWithSqlite.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HRController : ControllerBase
    {
        private readonly HRContext _context;
        private readonly ILogger<HRController> _logger;

        public HRController(ILogger<HRController> logger, HRContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Department> Get()
        {
            var d = _context.Departments.ToList();
            return d;
        }
    }
}
