using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    [Table("Message")]
    public  class Message
    {
        public Message()
        {
            MessageJoins = new HashSet<MessageJoin>();
        }

        public int ID { get; set; }

        [Column("Message")]
        [StringLength(2000)]
        public string Message1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MessageJoin> MessageJoins { get; set; }
    }
}
