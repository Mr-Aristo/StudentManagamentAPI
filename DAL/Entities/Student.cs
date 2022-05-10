using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    [Table("Student")]
    public class Student
    {
        public Student()
        {
            Marks = new HashSet<Mark>();
            MessageJoins = new HashSet<MessageJoin>();
        }

        public int ID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public int? UserID { get; set; }

        public int? GroupID { get; set; }

        public virtual Group Group { get; set; }

     
        public virtual ICollection<Mark> Marks { get; set; }

       
        public virtual ICollection<MessageJoin> MessageJoins { get; set; }

        public virtual UserStudent UserStudent { get; set; }
    }
}
