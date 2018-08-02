using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GoogleKeepAssignment.Models;

namespace GoogleKeepAssignment.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class NotesController : ControllerBase
    {
        private readonly NotesContext _context;

        public NotesController(NotesContext context)
        {
            _context = context;
        }

        //repository pattern
        // GET: api/Notes
        [HttpGet]
        public IQueryable<Object> GetNote()
        {
            var result = from note in _context.Note
                         join checklist in _context.CheckList on note.Title equals checklist.Title
                         join label in _context.Label on note.Title equals label.Title
                         select new
                         {
                             Title = note.Title,
                             PlainText = note.PlainText,
                             PinStatus = note.PinStatus,
                             CheckListData = checklist.CheckListData,
                             CheckListStatus = checklist.CheckListStatus,
                             LabelString = label.LabelString
                         };
            return result;
        }

        [HttpGet("search")]
        public IQueryable<Object> SearchByLabel([FromQuery] string labels)
        {
            var result = from note in _context.Note
                         join checklist in _context.CheckList on note.Title equals checklist.Title
                         join label in _context.Label on note.Title equals label.Title
                         where label.LabelString ==  labels
                         select new
                         {
                             Title = note.Title,
                             PlainText = note.PlainText,
                             PinStatus = note.PinStatus,
                             CheckListData = checklist.CheckListData,
                             CheckListStatus = checklist.CheckListStatus,
                             LabelString = label.LabelString
                         };

            return result;
        }

        [HttpGet("title")]
        public IQueryable<Object> SearchByTitle([FromQuery] string title)
        {
            var result = from note in _context.Note
                         join checklist in _context.CheckList on note.Title equals checklist.Title
                         join label in _context.Label on note.Title equals label.Title
                         where label.LabelString == title
                         select new
                         {
                             Title = note.Title,
                             PlainText = note.PlainText,
                             PinStatus = note.PinStatus,
                             CheckListData = checklist.CheckListData,
                             CheckListStatus = checklist.CheckListStatus,
                             LabelString = label.LabelString
                         };

            return result;
        }

        [HttpGet("pinned")]
        public IQueryable<Object> SearchPinnedNotes()
        {
            var result = from note in _context.Note
                         join checklist in _context.CheckList on note.Title equals checklist.Title
                         join label in _context.Label on note.Title equals label.Title
                         where note.PinStatus == true
                         select new
                         {
                             Title = note.Title,
                             PlainText = note.PlainText,
                             PinStatus = note.PinStatus,
                             CheckListData = checklist.CheckListData,
                             CheckListStatus = checklist.CheckListStatus,
                             LabelString = label.LabelString
                         };

            return result;
        }

        [HttpGet("retrieve")]
        public IQueryable<Object> GetByStatus([FromQuery] bool status)
        {
            var result = from note in _context.Note
                         join checklist in _context.CheckList on note.Title equals checklist.Title
                         join label in _context.Label on note.Title equals label.Title
                         where note.PinStatus == status
                         select new
                         {
                             Title = note.Title,
                             PlainText = note.PlainText,
                             PinStatus = note.PinStatus,
                             CheckListData = checklist.CheckListData,
                             CheckListStatus = checklist.CheckListStatus,
                             LabelString = label.LabelString
                         };
            return result;
        }
        // GET: api/Notes/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetNote([FromRoute] string id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var note = await _context.Note.FindAsync(id);

            if (note == null)
            {
                return NotFound();
            }

            return Ok(note);
        }

        // PUT: api/Notes/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutNote([FromRoute] string id, [FromBody] Note note)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != note.Title)
            {
                return BadRequest();
            }

            _context.Entry(note).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NoteExists(id))
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

        // POST: api/Notes
        [HttpPost]
        public async Task<IActionResult> PostNote([FromBody] Note note)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Note.Add(note);
            await _context.SaveChangesAsync();

            //return CreatedAtAction("GetNote", new { id = note.Title }, note);
            return StatusCode(201, note);
        }

        // DELETE: api/Notes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteNote([FromRoute] string id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var note = await _context.Note.FindAsync(id);
            if (note == null)
            {
                return NotFound();
            }

            _context.Note.Remove(note);
            await _context.SaveChangesAsync();

            return Ok(note);
        }

        private bool NoteExists(string id)
        {
            return _context.Note.Any(e => e.Title == id);
        }
    }
}