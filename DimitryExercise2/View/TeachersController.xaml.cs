using DimitryExercise2.Model;
using System.Windows.Controls;

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
                DAL.ChoosedTeacher(teacher);
        }
    }
}
