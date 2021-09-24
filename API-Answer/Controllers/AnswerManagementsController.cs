using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API_Answer.Models;
using ApiService.Models;

namespace API_Answer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnswerManagementsController : ControllerBase
    {
        private readonly AnswerDbContext _context;

        public AnswerManagementsController(AnswerDbContext context)
        {
            _context = context;
        }

        // GET: api/AnswerManagements
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AnswerManagement>>> GetAnswerManagement()
        {
            return await _context.AnswerManagement.ToListAsync();
        }

        // GET: api/AnswerManagements/5
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<AnswerManagement>>> GetAnswerManagement(int id, AnswerManagement x)
        {
            var answerManagement = await _context.AnswerManagement.Where(x => x.qst_id == id).ToListAsync();

            if (answerManagement == null)
            {
                return NotFound();
            }
                
            return answerManagement;
        }

        // PUT: api/AnswerManagements/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAnswerManagement(int? id, AnswerManagement answerManagement)
        {
            if (id != answerManagement.ans_id)
            {
                return BadRequest();
            }

            _context.Entry(answerManagement).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AnswerManagementExists(id))
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

        // POST: api/AnswerManagements
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<AnswerManagement>> PostAnswerManagement(AnswerManagement answerManagement)
        {
            _context.AnswerManagement.Add(answerManagement);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAnswerManagement", new { id = answerManagement.ans_id }, answerManagement);
        }

        // DELETE: api/AnswerManagements/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAnswerManagement(int? id)
        {
            var answerManagement = await _context.AnswerManagement.FindAsync(id);
            if (answerManagement == null)
            {
                return NotFound();
            }

            _context.AnswerManagement.Remove(answerManagement);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AnswerManagementExists(int? id)
        {
            return _context.AnswerManagement.Any(e => e.ans_id == id);
        }
    }
}
