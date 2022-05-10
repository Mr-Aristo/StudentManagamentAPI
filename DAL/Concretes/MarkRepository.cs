using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;
using DAL.Repositories.Abstracts;

namespace DAL.Repositories.Concretes
{
    public class MarkRepository: IRepository<Mark>
    {
        private SMContext db;

        public MarkRepository(SMContext context)
        {
            db = context;
        }

        public void Add(Mark entity)
        {
            db.Marks.Add(entity);
        }

        public List<Mark> GetAll()
        {
            return db.Marks.ToList();
        }

        public Mark GetByID(int id)
        {
            return db.Marks.Find(id);
        }

        public void Remove(int id)
        {
            db.Marks.Remove(GetByID(id));
        }

        public void Update(Mark entity)
        {
            db.Update(entity);
        }
    }
}
