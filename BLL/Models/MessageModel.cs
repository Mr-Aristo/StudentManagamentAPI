using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;

namespace BLL.Models
{
    public class MessageModel
    {
        public int ID { get; set; }

        
        public string Message1 { get; set; }

        public MessageModel() { }
        public MessageModel(Message ms) 
        {
            ID = ms.ID;
            Message1 = ms.Message1;
        }
    }
}
