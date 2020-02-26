using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using rental.Models;

namespace rental.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MembershipTypesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public MembershipTypesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/MembershipTypes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MembershipType>>> GetMembershipTypes()
        {
            return await _context.MembershipTypes.ToListAsync();
        }

        // GET: api/MembershipTypes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MembershipType>> GetMembershipType(byte id)
        {
            var membershipType = await _context.MembershipTypes.FindAsync(id);

            if (membershipType == null)
            {
                return NotFound();
            }

            return membershipType;
        }

        // PUT: api/MembershipTypes/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMembershipType(byte id, MembershipType membershipType)
        {
            if (id != membershipType.Id)
            {
                return BadRequest();
            }

            _context.Entry(membershipType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MembershipTypeExists(id))
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

        // POST: api/MembershipTypes
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<MembershipType>> PostMembershipType(MembershipType membershipType)
        {
            _context.MembershipTypes.Add(membershipType);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (MembershipTypeExists(membershipType.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetMembershipType", new { id = membershipType.Id }, membershipType);
        }

        // DELETE: api/MembershipTypes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<MembershipType>> DeleteMembershipType(byte id)
        {
            var membershipType = await _context.MembershipTypes.FindAsync(id);
            if (membershipType == null)
            {
                return NotFound();
            }

            _context.MembershipTypes.Remove(membershipType);
            await _context.SaveChangesAsync();

            return membershipType;
        }

        private bool MembershipTypeExists(byte id)
        {
            return _context.MembershipTypes.Any(e => e.Id == id);
        }
    }
}
