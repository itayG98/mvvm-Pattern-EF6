using DimitryExercise2.Model;
using System.Collections.ObjectModel;

namespace DimitryExercise2.ViewModels
{
    public class TeacherControllerViewModel : ViewModelBase
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
            foreach(Teacher teacher in DAL.GetTeachers())
                teachers.Add(teacher);
        }
    }
}
