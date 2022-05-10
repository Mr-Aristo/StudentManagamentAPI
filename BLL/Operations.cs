using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;
using DAL.Repositories.Abstracts;
using DAL.Repositories.Concretes;
using BLL.Models;
using BLL.Interfaces;


namespace BLL
{
    public class Operations : IDbCRUD
    {
        IUnitofWork db;
        public Operations(IUnitofWork context)
        {
            db = context;
        }




        #region USERS CRUD
        public void CreateTUser(UserTeacherModel ut)
        {
            db.UserTeacher.Add(new UserTeacher
            {
                ID = ut.ID,
                TeacherLogin = ut.TeacherLogin,
                TeacherPass = ut.TeacherPass
            });
            db.Save();
        }

        public void DeleteTUser(int pr)
        {
            db.UserTeacher.Remove(pr);
            db.Save();
        }

        public void CreateSUser(UserStudentModel us)
        {
            db.UserStudent.Add(new UserStudent
            {
                ID = us.ID,
                StudentLogin = us.StudentLogin,
                StudentPass = us.StudentPass
            });
            db.Save();
        }

        public void DeleteSUser(int pr)
        {
            db.UserStudent.Remove(pr);
            db.Save();

        }
        #endregion


        #region ModelLists

        //Mark
        public List<MarkModel> GetAllMarks()
        {
            return db.Mark.GetAll().Select(i => new MarkModel(i)).ToList();
        }

        //Student
        public List<StudentModel> GetAllStudents()
        {
            return db.Student.GetAll().Select(i => new StudentModel(i)).ToList();
        }
        //Type Mark
        public List<TypeMarkModel> GetAllTypeMarks()
        {
            return db.TypeMark.GetAll().Select(i => new TypeMarkModel(i)).ToList();
        }

        //User Student 
        public List<UserStudentModel> GetAllLogStudent()
        {
            return db.UserStudent.GetAll().Select(i => new UserStudentModel(i)).ToList();
        }

        //User Teacher 
        public List<UserTeacherModel> GetAllLogTeacher()
        {
            return db.UserTeacher.GetAll().Select(i => new UserTeacherModel(i)).ToList();
        }
        
        //Teacher
        public List<TeacherModel> GetTeachers()
        {
            return db.Teacher.GetAll().Select(i => new TeacherModel(i)).ToList();
        }

        //Discipline
        public List<DisciplineModel> GetAllDiscipline()
        {
            return db.Discipline.GetAll().Select(i => new DisciplineModel(i)).ToList();
        }

        public List<GroupModel> GetAllGroup()
        {
            return db.Group.GetAll().Select(i => new GroupModel(i)).ToList() ;

        }
        

        #endregion

        public void CreateFaculty(FacultyModel f)
        {
            db.Faculty.Add(new Faculty
            {
                ID = f.ID,
                FacultyName = f.FacultyName

            });
            db.Save();

        }

        public void CreateGroup(GroupModel g)
        {
            db.Group.Add(new Group
            {
                ID = g.ID,
                Group1 = g.Group1,

            });
            db.Save();



        }

        public void CreateDiscipline(DisciplineModel d)
        {
            db.Discipline.Add(new Disciplines
            {
                ID = d.ID,
                DisciplineTitle = d.DisciplineTitle
            });
            db.Save();
        }

        public void CreateStudent(StudentModel st)
        {
            db.Student.Add(new Student
            {
                ID = st.ID,
                Name = st.Name,
                GroupID = st.GroupID,
                UserID = st.UserID
                
            });
            db.Save();
        }

        public void DeleteStudent(int st)
        {
            db.Student.Remove(st);
            db.Save();
        }

        public void CreateTeacher(TeacherModel tc)
        {
            db.Teacher.Add(new Teacher
            {
                ID = tc.ID,
                UserID = tc.UserID,
                Name = tc.Name,
            });
            db.Save();
        }

        public void DeleteTeacher(int st)
        {
            db.Teacher.Remove(st);
            db.Save();
        }

        public void CreateMark(MarkModel mk)
        {
            db.Mark.Add(new Mark
            {
                ID = mk.ID,
                TypeMarkID = mk.TypeMarkID,
                StudentID = mk.StudentID,
                Result = mk.Result
            });
        }
    }
    
}

    

