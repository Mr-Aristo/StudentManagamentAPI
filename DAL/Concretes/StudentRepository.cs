using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;
using DAL.Repositories.Abstracts;

namespace DAL.Repositories.Concretes
{
    public class StudentRepository: IRepository<Student>
    {
        private SMContext db;

        public StudentRepository() { }
        public StudentRepository(SMContext context) 
        {
            db = context;
        }

        public void Add(Student entity)
        {
            db.Students.Add(entity);
        }

        public List<Student> GetAll()
        {
            return db.Students.ToList();
        }

        public Student GetByID(int id)
        {
            return db.Students.Find(id);
        }

        public void Remove(int id)
        {
            db.Students.Remove(GetByID(id));
        }

        public void Update(Student entity)
        {
            db.Update(entity);
        }
    }
}
