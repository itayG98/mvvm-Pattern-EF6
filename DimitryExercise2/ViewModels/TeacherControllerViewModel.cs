using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DimitryExercise2.ViewModels
{
    public class TeacherControllerViewModel
    {
        DAL_Service DAL = DAL_Service.Init;
        private readonly ObservableCollection<Teacher> teachers;

        public ObservableCollection<Teacher> Teachers => teachers;

        public TeacherControllerViewModel()
        {
            teachers = new ObservableCollection<Teacher>();
            GetTeachers();
        }

        public void GetTeachers()
        {
            teachers.Clear();
            foreach (Teacher teacher in DAL.GetTeachers())
                teachers.Add(teacher);
        }
    }
}
