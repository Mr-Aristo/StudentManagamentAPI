using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;
namespace BLL.Models
{
    public class TeacherModel
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public int UserID { get; set; } 

        public TeacherModel() { }
        public TeacherModel(Teacher tc)
        {
            ID = tc.ID;
            UserID = tc.UserID;
            Name = tc.Name;
        }

    }
}
