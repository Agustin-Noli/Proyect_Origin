using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ApiOrigin.Contexts;
using ApiOrigin.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApiOrigin.Controllers
{
    [Route("api/[controller]")]
    public class ReporteController : Controller
    {
        private readonly AppDBContext context;
        public ReporteController(AppDBContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Reporte>>> GetReporte()
        {
            return await context.Reporte.ToListAsync();
            
        }




    }
}