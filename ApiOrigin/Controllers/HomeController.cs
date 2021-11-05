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
    public class HomeController : Controller
    {
        private readonly AppDBContext context;
        public HomeController(AppDBContext context)
        {
            this.context = context;
        }


        [HttpGet("{tarjeta}")]
        public async Task<ActionResult<Home>> GetTarjeta(string tarjeta)
        {
            var Home = await context.Home.FirstOrDefaultAsync(e => e.tarjeta == tarjeta);

            if (Home == null)
                return NotFound();

            return Home;
        }

        [HttpPut("{tarjeta}")]
        public async Task<ActionResult<Home>> UpdateTarjeta([FromRoute] string tarjeta, [FromBody] Home home)
        {
            if (tarjeta != home.tarjeta)
                return BadRequest();

            context.Entry(home).State = EntityState.Modified;

            await context.SaveChangesAsync();

            return NoContent();
        }







    }
}