using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Repositories.Abstracts;
using DAL.Entities;
namespace DAL.Repositories.Concretes
{
    public class UserStudentRepository : IRepository<UserStudent>
    {
        private SMContext db;

        
        public UserStudentRepository(SMContext context)
        {
            db = context;
        }
        public void Add(UserStudent entity)
        {
            db.UserStudents.Add(entity);
        }

        public List<UserStudent> GetAll()
        {
            return db.UserStudents.ToList();
        }

        public UserStudent GetByID(int id)
        {
           return db.UserStudents.Find(id);
        }

        public void Remove(int id)
        {
            db.UserStudents.Remove(GetByID(id));
        }

        public void Update(UserStudent entity)
        {
            db.Update(entity);
        }
    }
}
