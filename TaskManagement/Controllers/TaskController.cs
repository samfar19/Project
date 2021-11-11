using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TaskManagement.Models;
using Microsoft.Extensions.Logging;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TaskManagement.Controllers
{
    [Route("api/[controller]")]
    public class TaskController : Controller
    {
        private readonly TaskManagementContext _context;

        public TaskController(TaskManagementContext context)
        {
            _context = context;
        }

        // GET: api/values
        [HttpGet]
        public async Task<ActionResult<IEnumerable<_Task>>> GetTask()
        {
            return await _context.Tasks
                 .ToListAsync();

        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<ActionResult<_Task>> GetTask(int id)
        {
            var _task = await _context.Tasks.FindAsync(id);

            if (_task == null)
            {
                return NotFound();
            }

            return _task;
        }

        // POST api/values
        [HttpPost]
        public async Task<ActionResult<_Task>> PostTask(_Task _task)
        {
            _context.Tasks.Add(_task);
            await _context.SaveChangesAsync();

            return CreatedAtAction("PostTask", new { id = _task.TaskId }, _task);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTask(int id, _Task _task)
        {
            if (id != _task.TaskId)
            {
                return BadRequest();
            }

            _context.Entry(_task).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TaskExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<_Task>> DeleteTask(int id)
        {
            var _task = await _context.Tasks.FindAsync(id);
            if (_task == null)
            {
                return NotFound();
            }

            _context.Tasks.Remove(_task);
            await _context.SaveChangesAsync();

            return _task;
        }

        private bool TaskExists(int id)
        {
            return _context.Tasks.Any(e => e.TaskId == id);
        }

       
    }
}
