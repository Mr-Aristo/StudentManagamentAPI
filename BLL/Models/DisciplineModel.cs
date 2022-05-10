using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;

namespace BLL.Models
{
   public class DisciplineModel
    {
        public int ID { get; set; }

        public string DisciplineTitle { get; set; }

        public DisciplineModel() { }
        public DisciplineModel(Disciplines ds)
        {
            ID = ds.ID;
            DisciplineTitle = ds.DisciplineTitle;

        }
    }
}
