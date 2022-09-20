using System;
using DimitryExercise2.Model;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;

namespace DimitryExercise2.ViewModels
{
    public class StudentControllerViewModel
    {
        DAL_Service DAL = DAL_Service.Init;
        private readonly ObservableCollection<Student> students;

        public ObservableCollection<Student> Students => students;

        public StudentControllerViewModel()
        {
            DAL.GetTeachersStudentsEvent += DAL_Service_GetTeachersStudents;
            students = new ObservableCollection<Student>();
            Students.Clear();
            DAL.GetStudents().ToList().ForEach(s => Students.Add(s));
        }

        public void DAL_Service_GetTeachersStudents(Teacher t)
        {
            if (t != null)
            {
                Students.Clear();
                foreach (var stud in t.Students)
                    Students.Add(stud);
            }
        }
    }
}
