using DimitryExercise2.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DimitryExercise2.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        readonly DAL_Service DAL = DAL_Service.Init;
        public ICommand RefreshButtonCommand { get; set; }

        public MainViewModel()
        {
            RefreshButtonCommand = new RefreshCommand();
        }

    }
}
