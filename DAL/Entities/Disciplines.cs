using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public  class Disciplines
    {
        public Disciplines()
        {
            Marks = new HashSet<Mark>();
        }

        [Key]
        public int ID { get; set; }

        [StringLength(50)]
        public string DisciplineTitle { get; set; }

     
        public virtual ICollection<Mark> Marks { get; set; }
    }
}
