using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;
using DAL.Repositories.Abstracts;

namespace DAL.Repositories.Concretes
{
    public class FacultyRepository: IRepository<Faculty>
    {

        private SMContext db;

        public FacultyRepository(SMContext context)
        {
            db = context;
        }

        public void Add(Faculty entity)
        {
            db.Faculties.Add(entity);
        }

        public List<Faculty> GetAll()
        {
            return db.Faculties.ToList();
        }

        public Faculty GetByID(int id)
        {
            return db.Faculties.Find(id);
        }

        public void Remove(int id)
        {
            db.Faculties.Remove(GetByID(id));
        }

        public void Update(Faculty entity)
        {
            db.Update(entity);
        }
    }
}
