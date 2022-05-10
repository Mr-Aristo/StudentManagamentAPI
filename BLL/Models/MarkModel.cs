using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;
namespace BLL.Models
{
    public class MarkModel
    {
        public int ID { get; set; }

        public int? Result { get; set; }

        public int TypeMarkID { get; set; }

        public int DisciplineID { get; set; }

        public int StudentID { get; set; }

        public MarkModel() { }
        public MarkModel(Mark mk)
        {
            ID = mk.ID;
            Result = mk.Result;
            TypeMarkID = mk.TypeMarkID;
            DisciplineID = mk.DisciplineID;
            StudentID = mk.StudentID;
        }

    }
}
