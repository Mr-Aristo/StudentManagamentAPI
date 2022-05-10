using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;

namespace BLL.Models
{
   public class FacultyModel
    {
        public int ID { get; set; }

        
        public string FacultyName { get; set; }

        public FacultyModel() { }
        public FacultyModel(Faculty fc)
        {
            ID = fc.ID;
            FacultyName = fc.FacultyName;
        }
    }
}
