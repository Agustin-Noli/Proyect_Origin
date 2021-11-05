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
    public class BalanceController : Controller
    {
        private readonly AppDBContext context;
        public BalanceController(AppDBContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Balance>>> GetBalance()
        {
            return await context.Balance.ToListAsync();
        }


        [HttpPost]
        public async Task<ActionResult<Balance>> CreateRegistro([FromBody] Balance balance)
        {
            try
            {
                context.Balance.Add(balance);
                await context.SaveChangesAsync();
                return Ok();


            }
            catch (Exception ex)

            {
                return BadRequest();

            }



        }
    }
}