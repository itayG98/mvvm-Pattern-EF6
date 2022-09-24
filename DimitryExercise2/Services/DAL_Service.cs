using DimitryExercise2.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DimitryExercise2
{
    public class DAL_Service
    {
        private static readonly DAL_Service _dataService = new DAL_Service();

        public ModelContainer data;
        public Action<Teacher> ChoosedTeacherEvent; 
        public Action<Student> ChoosedStudentEvent;

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
        public void AddPerson(params Person[] persons)
        {
            foreach (Person p in persons)
                data.People.Add(p);
            data.SaveChanges();
        }

        public void ChoosedStudent(Student s) => ChoosedStudentEvent?.Invoke(s);

    }
}
