using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Mark
    {
        [Key]
        public int ID { get; set; }

        public int? Result { get; set; }

        public int TypeMarkID { get; set; }

        public int DisciplineID { get; set; }

        public int StudentID { get; set; }

        public virtual Disciplines Discipline { get; set; }

        public virtual Student Student { get; set; }

        public virtual TypeMark TypeMark { get; set; }
    }
}
