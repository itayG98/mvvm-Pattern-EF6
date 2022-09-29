using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DimitryExercise2.Command
{
    public class RefreshCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private DAL_Service DAL = DAL_Service.Init;

        public bool CanExecute(object parameter) => true;

        public void Execute(object parameter)
        {

            DAL.SaveChangesAsync();
            DAL.RefreshLists();
        }
    }
}
