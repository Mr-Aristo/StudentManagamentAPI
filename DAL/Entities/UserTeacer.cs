using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    [Table("UserTeacher")]
    public class UserTeacher
    {
        public UserTeacher()
        {
            Teachers = new HashSet<Teacher>();
        }

        [Key]
        public int ID { get; set; }

        [StringLength(50)]
        public string TeacherLogin { get; set; }

        [StringLength(50)]
        public string TeacherPass { get; set; }

       
        public virtual ICollection<Teacher> Teachers { get; set; }
    }
}
