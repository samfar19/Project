using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Projects.Models;
using Microsoft.Extensions.Logging;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
namespace Projects.Controllers
{
    [Route("api/[controller]")]
    public class TaskController : Controller
    {
        /*private readonly EmployeeDbContext _context;

        public TaskController(EmployeeDbContext context)
        {
            _context = context;
        }


        // GET: api/values
        [HttpGet]
        public async Task<ActionResult<IEnumerable<_Task>>> GetTask()
        {
            return await _context.Tasks.ToListAsync();

        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<ActionResult<_Task>> GetTask(int id)
        {
            var task = await _context.Tasks.FindAsync(id);

            if (task == null)
            {
                return NotFound();
            }

            return task;
        }


        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }*/
    }
}
