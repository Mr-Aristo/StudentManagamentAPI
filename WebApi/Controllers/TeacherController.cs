using BLL.Interfaces;
using BLL.Models;
using DAL.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private IDbCRUD db;

        MarkModel marks = new MarkModel();

        public TeacherController(IDbCRUD context)
        {
            db = context;
            

        }

        [HttpGet("Students")]
        public JsonResult Get()
        {
            var val = db.GetAllStudents();

            return new JsonResult(val);

        }

        [HttpGet("Student_id")]
        public async Task<IActionResult> GetStudentByID([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            using var _db = new SMContext();
            var student = await _db.Students.Include(p => p.Name).SingleOrDefaultAsync(p => p.ID == id);

            if (student == null)
            {
                return NotFound();
            }
            return Ok(student);
        }

        [HttpPost("AddMark")]
        public JsonResult CreateUserTeacher([FromBody] int Result, int typeMarkId, int disciplineId, int studnetId)
        {
            marks.Result = Result;
            marks.StudentID = studnetId;
            marks.DisciplineID = disciplineId;
            marks.TypeMarkID = typeMarkId;

            db.CreateMark(marks);

            return new JsonResult("User Teacher Added Successfully ");
        }

        [HttpDelete("{Mark_id}")]
        public async Task<IActionResult> DeleteMark([FromBody] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            using var _db = new SMContext();
            var item = _db.Marks.Find(id);

            if (item == null)
            {
                return NotFound();
            }

            _db.Marks.Remove(item);
            await _db.SaveChangesAsync();
            return NoContent();
        }

        [HttpPut("{Mark_id}")]
        public async Task<IActionResult> UpdateMark([FromRoute] int mark_id, [FromBody] Mark marks)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            using var _db = new SMContext();
            var item = _db.Marks.Find(mark_id);

            if (item == null)
            {
                return NotFound();
            }

            item.Result = marks.Result;
            item.StudentID = marks.StudentID;   
            item.TypeMarkID = marks.TypeMarkID;
            item.DisciplineID = marks.DisciplineID;



            _db.Marks.Update(item);
            await _db.SaveChangesAsync();
            return NoContent();
        }

    }
}
