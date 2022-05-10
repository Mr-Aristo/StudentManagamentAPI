using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;

namespace BLL.Models
{
    public class GroupModel
    {
        public int ID { get; set; }
        public string Group1 { get; set; }

        public int FacultyID { get; set; }

        public GroupModel() { }
        public GroupModel(Group gp)
        {
            ID = gp.ID;
            Group1 = gp.Group1;
            FacultyID = gp.FacultyID;
        }
    }
}
