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

        public ObservableCollection<Courses> Courses { get; set; }
        public ObservableCollection<Courses> OtherCourses { get; set; }

        public Courses AddCourses
        {
            get { return default; }
            set
            {
                if (!Courses.Contains(value))
                {
                    Courses.Add(value);
                    OtherCourses.Remove(value);
                    curTeacher.Courses |= value;
                }
            }
        }
        public Courses RemoveCourses
        {
            get { return default; }
            set
            {
                if (Courses.Contains(value))
                {
                    Courses.Remove(value);
                    OtherCourses.Add(value);
                    curTeacher.Courses ^= value;
                }
            }
        }

        public EditTeacherControllerViewModel()
        {
            Courses = new ObservableCollection<Courses>();
            OtherCourses = new ObservableCollection<Courses>();
            DAL.ChoosedTeacherEvent += ChosedTeacher;
        }

        private void ChosedTeacher(Teacher t)
        {
            if (t is null)
                return;
            CurTeacher = t;
            Courses.Clear();
            foreach (var item in Enum.GetValues(typeof(Courses)).Cast<Courses>())
            {
                if (t.Courses.HasFlag(item))
                    Courses.Add(item);
                else
                    OtherCourses.Add(item);
            }
        }

    }
}
