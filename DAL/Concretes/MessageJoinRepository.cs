using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;
using DAL.Repositories.Abstracts;
namespace DAL.Repositories.Concretes
{
    public class MessageJoinRepository: IRepository<MessageJoin>
    {
        private SMContext db;

        public MessageJoinRepository(SMContext context)
        {
            db = context;
        }

        public void Add(MessageJoin entity)
        {
            db.MessageJoins.Add(entity);
        }

        public List<MessageJoin> GetAll()
        {
            return db.MessageJoins.ToList();
        }

        public MessageJoin GetByID(int id)
        {
          return  db.MessageJoins.Find(id);
        }

        public void Remove(int id)
        {
            db.MessageJoins.Remove(GetByID(id));
        }

        public void Update(MessageJoin entity)
        {
            db.Update(entity);
        }
    }
}
