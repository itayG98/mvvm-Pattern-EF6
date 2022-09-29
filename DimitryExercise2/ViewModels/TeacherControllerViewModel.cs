using DimitryExercise2.Model;
using System.Collections.ObjectModel;

namespace DimitryExercise2.ViewModels
{
    public class TeacherControllerViewModel : ViewModelBase
    {
        readonly DAL_Service DAL = DAL_Service.Init;
        public ObservableCollection<Teacher> Teachers {get;set;}

        public TeacherControllerViewModel()
        {
            Teachers = new ObservableCollection<Teacher>();
            DAL.RefreshListsEvent+=GetTeachers;
            DAL.ChoosedStudentEvent += ChosedStudent;
        }

        public void GetTeachers()
        {
            Teachers.Clear();
            foreach(Teacher teacher in DAL.GetTeachers())
                Teachers.Add(teacher);
        }

        private void ChosedStudent(Student s) 
        {  
            Teachers.Clear();
            foreach (Teacher teacher in s.Teacher)
                Teachers.Add(teacher);
        }
    }
}
