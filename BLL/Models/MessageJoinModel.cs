using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;

namespace BLL.Models
{
   public class MessageJoinModel
    {
        public int MessageID { get; set; }
        public int StudentID { get; set; }  
        public int TeacherID { get; set; }

        public MessageJoinModel() { }
        public MessageJoinModel(MessageJoin msj)
        {
            MessageID = msj.MessageID;
            StudentID = msj.StudentID;
            TeacherID = msj.TeacherID;

        }
    }
}
