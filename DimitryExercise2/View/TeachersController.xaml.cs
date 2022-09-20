using DimitryExercise2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DimitryExercise2.View
{
    /// <summary>
    /// Interaction logic for TeachersController.xaml
    /// </summary>
    public partial class TeachersController : UserControl
    {
        private DAL_Service DAL = DAL_Service.Init;
        public TeachersController()
        {
            InitializeComponent();
        }
        private void OnSelectedChange(object sender, SelectionChangedEventArgs e)
        {
            if (sender.Equals(LVTeachers) && LVTeachers.SelectedItem is Teacher teacher)
                DAL.GetTeachersStudents(teacher);
        }
    }
}
