using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        private bool _canExecute;

        public bool CanExecuteBool
        {
            get { return _canExecute; }
            set
            {
                _canExecute = value;
                CanExecuteChanged?.Invoke(default, new EventArgs());
            }
        }

        public RefreshCommand()
        {
            CanExecuteBool = true;
        }

        public bool CanExecute(object parameter) => CanExecuteBool;

        public void Execute(object parameter)
        {
            if (CanExecute(default))
            {
                CanExecuteBool = false;
                DAL.SaveChanges();
                DAL.RefreshLists();
                CanExecuteBool = true;
            }
        }
    }
}
