using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;
using DAL.Repositories.Abstracts;
namespace DAL.Repositories.Concretes
{
    public class UserTeacherRepository : IRepository<UserTeacher>
    {
        private SMContext db;

        public UserTeacherRepository() { }
        public UserTeacherRepository(SMContext context)
        {
            db = context;
        }
        public void Add(UserTeacher entity)
        {
            db.UserTeachers.Add(entity);
        }

        public List<UserTeacher> GetAll()
        {
            return db.UserTeachers.ToList();
        }

        public UserTeacher GetByID(int id)
        {
            return db.UserTeachers.Find(id);
        }

        public void Remove(int id)
        {
            db.UserTeachers.Remove(GetByID(id));
        }

        public void Update(UserTeacher entity)
        {
            db.Update(entity);
        }
    }
}
