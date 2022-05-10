using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;
using DAL.Repositories.Abstracts;

namespace DAL.Repositories.Concretes
{
    public class MessageRepository: IRepository<Message>
    {
        private SMContext db;

        public MessageRepository(SMContext context)
        {
            db = context;
        }

        public void Add(Message entity)
        {
            db.Messages.Add(entity);
        }

        public List<Message> GetAll()
        {
            return db.Messages.ToList();
        }

        public Message GetByID(int id)
        {
            return db.Messages.Find(id);
        }

        public void Remove(int id)
        {
            db.Messages.Remove(GetByID(id));
        }

        public void Update(Message entity)
        {
            db.Update(entity);
        }
    }
}
