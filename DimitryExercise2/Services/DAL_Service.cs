using DimitryExercise2.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace DimitryExercise2
{
    /// <summary>
    /// Data Acces Layer
    /// </summary>
    public class DAL_Service
    {
        private static readonly DAL_Service _dataService = new DAL_Service();

        public ModelContainer data;
        public Action<Teacher> ChoosedTeacherEvent; 
        public Action<Student> ChoosedStudentEvent;
        public Action EditPersonEvent;


        public static DAL_Service Init
        {
            get
            {
                if (_dataService == null)
                    return new DAL_Service();
                else return _dataService;
            }
        }
        private DAL_Service()
        {
            data = new ModelContainer();
        }

        public IEnumerable<Teacher> GetTeachers() => (data.People.OfType<Teacher>());

        public IEnumerable<Student> GetStudents() => (data.People.OfType<Student>());

        public void ChoosedTeacher(Teacher t)
            => ChoosedTeacherEvent?.Invoke(t);
        public void AddOrUpdatePerson(params Person[] persons)
        {
            foreach (Person p in persons)
                data.People.AddOrUpdate(p);
            data.SaveChanges();
            EditPersonEvent?.Invoke();
        }
        public void ChoosedStudent(Student s) => ChoosedStudentEvent?.Invoke(s);

    }
}
