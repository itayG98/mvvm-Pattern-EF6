﻿using DimitryExercise2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DimitryExercise2.ViewModels 
{
    public class EditStudentControllerViewModel : ViewModelBase
    {
        DAL_Service _dalService = DAL_Service.Init;
        public IObservable<Student> CurStudent { get; set; }
        public EditStudentControllerViewModel() 
        {

        }
    }
}
