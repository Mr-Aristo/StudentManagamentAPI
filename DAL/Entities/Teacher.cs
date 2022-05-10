using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    [Table("Teacher")]
    public class Teacher
    {
        public Teacher()
        {
            MessageJoins = new HashSet<MessageJoin>();
        }

        public int ID { get; set; }

        public int UserID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        
        public virtual ICollection<MessageJoin> MessageJoins { get; set; }

        public virtual UserTeacher UserTeacher { get; set; }
    }
}
