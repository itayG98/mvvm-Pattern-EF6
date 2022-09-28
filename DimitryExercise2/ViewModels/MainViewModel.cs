using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DimitryExercise2.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        DAL_Service DAL = DAL_Service.Init;
        public int SaveBarValue { get; set; }

        public MainViewModel()
        {
            SaveBarValue = 100;
            DAL.EditPersonEvent += FinishedSaving;
            DAL.SaveUpdateEvent += StartedSaving;
            DAL.CouldnSaveError += SaveError;
        }

        public void StartedSaving() => SaveBarValue = 25;
        public void FinishedSaving() => SaveBarValue = 100;
        public void SaveError() => SaveBarValue = 0;
    }
}
