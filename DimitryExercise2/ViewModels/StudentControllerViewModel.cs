using DimitryExercise2.Model;
using System.Collections.ObjectModel;
using System.Linq;

namespace DimitryExercise2.ViewModels
{
    public class StudentControllerViewModel : ViewModelBase
    {
        readonly DAL_Service DAL = DAL_Service.Init;
        private readonly ObservableCollection<Student> students;

        public ObservableCollection<Student> Students => students;

        public StudentControllerViewModel()
        {
            students = new ObservableCollection<Student>();
            DAL.ChoosedTeacherEvent += DAL_Service_GetTeachersStudents;
            DAL.RefreshListsEvent += GetStudents;
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

        public void GetStudents()
        {
            Students.Clear();
            foreach (Student student in DAL.GetStudents())
                Students.Add(student);
        }
    }
}
