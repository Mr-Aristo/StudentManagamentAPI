using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;

namespace DAL.Entities
{
    public partial class SMContext : DbContext
    {
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) // connection string tanimlamak icin bole bir yapi kurduk 
        {
            optionsBuilder.UseSqlServer("server=HOME-PC; database=Management; integrated security=true;");//Bu fonksiyon icin entitiyframework.core.sqlserver yuklenmesi gereklidir. 
        }

        public virtual DbSet<Disciplines> Disciplines { get; set; }
        public virtual DbSet<Faculty> Faculties { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<Mark> Marks { get; set; }
        public virtual DbSet<Message> Messages { get; set; }
        public virtual DbSet<MessageJoin> MessageJoins { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<TypeMark> TypeMarks { get; set; }
        public virtual DbSet<UserStudent> UserStudents { get; set; }
        public virtual DbSet<UserTeacher> UserTeachers { get; set; }

     
    }
}
