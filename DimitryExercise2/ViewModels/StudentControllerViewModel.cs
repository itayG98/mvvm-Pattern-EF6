using System.Collections.ObjectModel;

namespace DimitryExercise2.ViewModels
{
    public class StudentControllerViewModel
    {
        DAL_Service DAL = DAL_Service.Init;
        private readonly ObservableCollection<Student> students;

        public ObservableCollection<Student> Students => students;

        public StudentControllerViewModel()
        {
            students = new ObservableCollection<Student>();
            GetStudents();
        }

        public void GetStudents() 
        {
            students.Clear();
            foreach(Student student in DAL.GetStudents())
                Students.Add(student);
        }
    }
}
