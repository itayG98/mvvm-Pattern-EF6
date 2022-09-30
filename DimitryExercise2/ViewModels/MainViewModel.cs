using DimitryExercise2.Command;
using System;
using System.Windows.Input;

namespace DimitryExercise2.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        readonly DAL_Service DAL = DAL_Service.Init;
        public ICommand RefreshButtonCommand { get; set; }
        private bool _refreshButtonCommand;
        public bool RefreshButtonCommandSate
        {
            get
            {
                return _refreshButtonCommand;
            }
            private set
            {
                _refreshButtonCommand = value;
                NotifyPropertyChanged(nameof(RefreshButtonCommandSate));
            }
        }

        public MainViewModel()
        {
            RefreshButtonCommand = new RefreshCommand();
            RefreshButtonCommand.CanExecuteChanged += RefreshButtonCommand_CanExecuteChanged;
            RefreshButtonCommandSate = RefreshButtonCommand.CanExecute(default);
        }

        private void RefreshButtonCommand_CanExecuteChanged(object sender, EventArgs e) =>
            _refreshButtonCommand = RefreshButtonCommand.CanExecute(default);
    }
}
