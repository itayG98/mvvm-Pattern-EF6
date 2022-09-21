using DimitryExercise2.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace DimitryExercise2.ViewModels
{
    public class EditTeacherControllerViewModel : ViewModelBase
    {
        readonly DAL_Service DAL = DAL_Service.Init;
        private Teacher curTeacher;

        public Teacher CurTeacher
        {
            get { return curTeacher; }
            set
            {
                if (value != null)
                {
                    curTeacher = value;
                    NotifyPropertyChanged(nameof(CurTeacher));
                }
            }
        }
        public EditTeacherControllerViewModel()
        {
            DAL.ChoosedTeacherEvent += ChosedTeacher;
        }

        private void ChosedTeacher(Teacher t)
        {
            if (t != null) CurTeacher = t;
        }
    }
}
