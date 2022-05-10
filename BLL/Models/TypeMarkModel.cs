using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;

namespace BLL.Models
{
  public  class TypeMarkModel
    {
        public int ID { get; set; }
        public string TypeMark1 { get; set; }


        public TypeMarkModel() { }
        public TypeMarkModel(TypeMark tm)
        {
            ID = tm.ID;
            TypeMark1 = tm.TypeMark1;
        }
    }
}
