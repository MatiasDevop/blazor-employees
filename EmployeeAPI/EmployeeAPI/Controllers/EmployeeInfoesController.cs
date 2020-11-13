using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EmployeeAPI;

namespace EmployeeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeInfoesController : ControllerBase
    {
        private readonly EmployeeDbContext _context;

        public EmployeeInfoesController(EmployeeDbContext context)
        {
            _context = context;
        }

        // GET: api/EmployeeInfoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EmployeeInfo>>> GetEmployeeInfos()
        {
            // var list = new List<EmployeeInfo>();
            // var employee = new EmployeeInfo(){
            //     EmployeeId = "321312312",
            //     Name = "Bruce",
            //     Designation = "superheroe",
            //     Deparment = "small size"
            // };
            //list.Add(employee);
            return  await _context.EmployeeInfos.ToListAsync();//list.ToList();
        }

        // GET: api/EmployeeInfoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EmployeeInfo>> GetEmployeeInfo(string id)
        {
            var employeeInfo = await _context.EmployeeInfos.FindAsync(id);

            if (employeeInfo == null)
            {
                return NotFound();
            }

            return employeeInfo;
        }

        // PUT: api/EmployeeInfoes/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmployeeInfo(string id, EmployeeInfo employeeInfo)
        {
            if (id != employeeInfo.EmployeeId)
            {
                return BadRequest();
            }

            _context.Entry(employeeInfo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmployeeInfoExists(id))
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

        // POST: api/EmployeeInfoes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EmployeeInfo>> PostEmployeeInfo(EmployeeInfo employeeInfo)
        {
            _context.EmployeeInfos.Add(employeeInfo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEmployeeInfo", new { id = employeeInfo.EmployeeId }, employeeInfo);
        }

        // DELETE: api/EmployeeInfoes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EmployeeInfo>> DeleteEmployeeInfo(string id)
        {
            var employeeInfo = await _context.EmployeeInfos.FindAsync(id);
            if (employeeInfo == null)
            {
                return NotFound();
            }

            _context.EmployeeInfos.Remove(employeeInfo);
            await _context.SaveChangesAsync();

            return employeeInfo;
        }

        private bool EmployeeInfoExists(string id)
        {
            return _context.EmployeeInfos.Any(e => e.EmployeeId == id);
        }
    }
}
