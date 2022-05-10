using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;

namespace BLL.Models
{
    public class UserStudentModel
    {
        public int ID { get; set; }

        public string StudentLogin { get; set; }

        public string StudentPass { get; set; }

        public UserStudentModel() { }
        public UserStudentModel(UserStudent userStudent)
        {
            ID = userStudent.ID;
            StudentLogin = userStudent.StudentLogin;
            StudentPass = userStudent.StudentPass;
        }
    }
}
