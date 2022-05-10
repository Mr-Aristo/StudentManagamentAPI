using BLL.Interfaces;
using BLL.Models;
using DAL.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private IDbCRUD db;
        private readonly ILoggerManager _log;

        StudentModel st = new StudentModel();
        TeacherModel tc = new TeacherModel();
        UserStudentModel userStudent = new UserStudentModel();
        UserTeacherModel userTeacher = new UserTeacherModel();
        public AdminController(IDbCRUD context)
        {
            db = context;
        }


        [HttpGet("Students")]
        public JsonResult Get()
        {
            var val = db.GetAllStudents();

            return new JsonResult(val);

        }

        [HttpGet("Teachers")]
        public JsonResult GetTeacher()
        {
            var val = db.GetTeachers();

            return new JsonResult(val);
        }

        [HttpGet("UserStudents")]
        public JsonResult GetUsersStudent()
        {
            var val = db.GetAllLogStudent();

            return new JsonResult(val);
        }


        [HttpGet("UserTeachers")]
        public JsonResult GetUserTeacher()
        {
            var val = db.GetAllLogStudent();

            return new JsonResult(val);
        }


        [HttpPost("CreateStudent")]
        public JsonResult CreateStudent(string name, int groupId, int userId)
        {
            st.Name = name;
            st.UserID = userId;
            st.GroupID = groupId;
            db.CreateStudent(st);



            return new JsonResult("Student Added Successfully");
        }

        [HttpPost("CreateTeacher")]

        public JsonResult CreateTeacher(string name, int userid)
        {
            try
            {
                tc.Name = name;
                tc.UserID = userid;
                db.CreateTeacher(tc);

                return new JsonResult("Teacher Added");
            }
            catch (Exception ex)
            {
                _log.LogError($"Data could't created !:{ex.Message}");

                return new JsonResult("Teacher Couldn't Added");
            }

        }


        [HttpPost("CreateUserStudent")]
        public JsonResult CreateUserStudent(string login, string pass)
        {
            try
            {
                userStudent.StudentLogin = login;
                userStudent.StudentPass = pass;

                db.CreateSUser(userStudent);

                return new JsonResult("User Student Added Successfully");
            }
            catch (Exception ex)
            {
                _log.LogError($"Data could't created !:{ex.Message}");

                return new JsonResult("Student Couldn't Added");
            }
        }

        [HttpPost("CreateUserTeacher")]
        public JsonResult CreateUserTeacher(string login, string pass)
        {
            userTeacher.TeacherLogin = login;
            userTeacher.TeacherPass = pass;
            db.CreateTUser(userTeacher);

            return new JsonResult("User Teacher Added Successfully ");
        }

        [HttpDelete("DeleteStudent/{student_id}")]
        public async Task<IActionResult> DeleteStudent(int id)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                using var c = new SMContext();
                var item = c.Students.Find(id);

                if (item == null)
                {
                    return NotFound();
                }

                c.Students.Remove(item);
                await c.SaveChangesAsync();
                return NoContent();
            }
            catch (Exception ex)
            {
                _log.LogError($"Data Couldn't Deleted :{ex.Message}");

                return StatusCode(500, "Internal Server Error");
            }
        }

        [HttpDelete("{Teacher_id}")]

        public async Task<IActionResult> DeleteTeacher(int id)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                using var _db = new SMContext();
                var item = _db.Teachers.Find(id);

                if (item == null)
                {
                    return NotFound();
                }

                _db.Teachers.Remove(item);
                await _db.SaveChangesAsync();
                return NoContent();
            }
            catch (Exception ex)
            {
                _log.LogError($"Data Couldn't Deleted :{ex.Message}");

                return StatusCode(500, "Internal Server Error");
            }
        }

        [HttpPut("{Student_id}")]
        public async Task<IActionResult> UpdateStudent([FromRoute] int student_id, [FromBody] Student student)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                using var _db = new SMContext();
                var item = _db.Students.Find(student_id);

                if (item == null)
                {
                    return NotFound();
                }

                item.Name = student.Name;
                item.UserID = student.UserID;
                item.GroupID = student.GroupID;



                _db.Students.Update(item);
                await _db.SaveChangesAsync();
                return NoContent();
            }
            catch (Exception ex)
            {
                _log.LogError($"Data Couldn't Updated :{ex.Message}");

                return StatusCode(500, "Internal Server Error");
            }
        }

        [HttpPut("{Teacher_id}")]
        public async Task<IActionResult> UpdateTeacher([FromRoute] int teacher_id, [FromBody] Teacher teacher)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                using var _db = new SMContext();
                var item = _db.Teachers.Find(teacher_id);

                if (item == null)
                {
                    return NotFound();
                }

                item.Name = teacher.Name;
                item.UserID = teacher.UserID;



                _db.Teachers.Update(item);
                await _db.SaveChangesAsync();
                return NoContent();
            }
            catch (Exception ex)
            {
                _log.LogError($"Data Couldn't Updated :{ex.Message}");

                return StatusCode(500, "Internal Server Error");
            }
        }
    }
}
