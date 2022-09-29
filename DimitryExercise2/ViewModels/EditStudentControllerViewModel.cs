using DimitryExercise2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DimitryExercise2.ViewModels 
{
    public class EditStudentControllerViewModel : ViewModelBase
    {
        readonly DAL_Service DAL = DAL_Service.Init;
        private Student curStudent;
        public Student CurStudent 
        { get 
            { return curStudent; }
            set
            {
                if (value != null)
                {
                    curStudent = value;
                    NotifyPropertyChanged(nameof(CurStudent));
                }
            }
        }
        public EditStudentControllerViewModel() 
        {
            DAL.ChoosedStudentEvent += DAL_Service_GetStudent;
        }

        private void DAL_Service_GetStudent(Student s) => CurStudent = s;
    }
}
