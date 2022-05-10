using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;
using DAL.Repositories.Abstracts;

namespace DAL.Repositories.Concretes
{
   public class DisciplineRepository: IRepository<Disciplines>
    {
        private SMContext db;

        public DisciplineRepository(SMContext context)
        {
            db = context;
        }

        public void Add(Disciplines entity)
        {
            db.Disciplines.Add(entity);
        }

        public List<Disciplines> GetAll()
        {
            return db.Disciplines.ToList();
        }

        public Disciplines GetByID(int id)
        {
            return db.Disciplines.Find(id);
        }

        public void Remove(int id)
        {
            db.Disciplines.Remove(GetByID(id));
        }

        public void Update(Disciplines entity)
        {
            db.Update(entity);
        }
    }
}
