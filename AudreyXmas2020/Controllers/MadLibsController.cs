using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AudreyXmas2020.Data;

namespace AudreyXmas2020.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MadLibsController : ControllerBase
    {
        private readonly SqlDbContext _context;

        public MadLibsController(SqlDbContext context)
        {
            _context = context;
        }

        // GET: MadLibs
        [HttpGet]
        [Route("Get")]
        public async Task<List<MadLib>> Index()
        {
            return await _context.MadLibs.ToListAsync();
        }
    }
}
