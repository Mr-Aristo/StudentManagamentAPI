using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;
using DAL.Repositories.Abstracts;

namespace DAL.Repositories.Concretes
{
    public class GroupRepository: IRepository<Group>
    {

        private SMContext db;

        public GroupRepository(SMContext context)
        {
            db = context;
        }

        public void Add(Group entity)
        {
            db.Groups.Add(entity);
        }

        public List<Group> GetAll()
        {
            return db.Groups.ToList();
        }

        public Group GetByID(int id)
        {
            return db.Groups.Find(id);
        }

        public void Remove(int id)
        {
            db.Groups.Remove(GetByID(id));
        }

        public void Update(Group entity)
        {
            db.Update(entity);
        }
    }
}
