using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BLL.Interfaces;
using BLL.Models;
using DAL.Entities;
using System;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        public IDbCRUD db;
        readonly ILoggerManager _log;

        public StudentController(IDbCRUD context)
        {
            db = context;

        }

        [HttpGet("Marks")]
        public JsonResult Get()
        {
            try
            {
                var val = db.GetAllMarks();

                return new JsonResult(val);
            }
            catch (Exception ex)
            {
                _log.LogError($"Couldn't Reach to data :{ex.Message}");
                return new JsonResult("Something went wrong");
            }

        }


    }
}
