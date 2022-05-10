using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    [Table("TypeMark")]
    public class TypeMark
    {
        public TypeMark()
        {
            Marks = new HashSet<Mark>();
        }
        [Key]
        public int ID { get; set; }

        [Column("TypeMark")]
        [StringLength(30)]
        public string TypeMark1 { get; set; }

        
        public virtual ICollection<Mark> Marks { get; set; }
    }
}
