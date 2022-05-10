using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    [Table("UserStudent")]
    public class UserStudent
    {
        public UserStudent()
        {
            Students = new HashSet<Student>();
        }
        [Key]
        public int ID { get; set; }

        [StringLength(50)]
        public string StudentLogin { get; set; }

        [StringLength(50)]
        public string StudentPass { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Student> Students { get; set; }
    }
}

