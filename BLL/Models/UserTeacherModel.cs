using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;
namespace BLL.Models
{
    public class UserTeacherModel
    {

        public int ID { get; set; }

        public string TeacherLogin { get; set; }

        public string TeacherPass { get; set; }
        public UserTeacherModel() { }

       public UserTeacherModel(UserTeacher ut)
        {
            ID = ut.ID;
            TeacherLogin = ut.TeacherLogin;
            TeacherPass = ut.TeacherPass;
        }
    }
}
