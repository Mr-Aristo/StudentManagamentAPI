using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;
using DAL.Repositories.Abstracts;

namespace DAL.Repositories.Concretes
{
    public class TeacherRepository: IRepository<Teacher>
    {
        private SMContext db;

        public TeacherRepository(SMContext context)
        {
            db = context;

        }

        public void Add(Teacher entity)
        {
            db.Teachers.Add(entity);
        }

        public List<Teacher> GetAll()
        {
            return db.Teachers.ToList();
        }

        public Teacher GetByID(int id)
        {
            return db.Teachers.Find(id);
        }

        public void Remove(int id)
        {
            db.Teachers.Remove(GetByID(id));
        }

        public void Update(Teacher entity)
        {
            db.Update(entity);
        }
    }
}
