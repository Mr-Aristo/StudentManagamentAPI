using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;
namespace BLL.Models
{
    public class StudentModel
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public int? UserID { get; set; }

        public int? GroupID { get; set; }

        public StudentModel() { }

        public StudentModel(Student st)
        {
            ID = st.ID;
            Name = st.Name;
            UserID = st.UserID;
            GroupID = st.GroupID;
            
        }

    }
}
