using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;
using DAL.Repositories;
using BLL.Models;
namespace BLL.Interfaces
{
    public interface IDbCRUD
    {
      
        List<StudentModel> GetAllStudents();
        List<TeacherModel> GetTeachers();
        List<MarkModel> GetAllMarks();
        List<TypeMarkModel> GetAllTypeMarks();
        List<DisciplineModel> GetAllDiscipline();

        List<UserStudentModel> GetAllLogStudent();
        List<UserTeacherModel> GetAllLogTeacher();

        List<GroupModel> GetAllGroup();
       
        
        

        #region CRUD USER
        void CreateTUser(UserTeacherModel ut);
        void DeleteTUser(int pr);

        void CreateSUser(UserStudentModel us);
        void DeleteSUser(int pr);
        #endregion

        void CreateFaculty(FacultyModel f);
        void CreateGroup(GroupModel g);
        void CreateDiscipline(DisciplineModel d);

        //Crud Student
        void CreateStudent(StudentModel st);
        void DeleteStudent(int st);

        //Crud Teacher
        void CreateTeacher(TeacherModel tc);
        void DeleteTeacher(int st);


        void CreateMark(MarkModel mk);
    }
}
