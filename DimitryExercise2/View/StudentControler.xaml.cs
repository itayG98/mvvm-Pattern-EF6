using DimitryExercise2.Model;
using System.Windows.Controls;

namespace DimitryExercise2.View
{
    /// <summary>
    /// Interaction logic for StudentControler.xaml
    /// </summary>
    public partial class StudentControler : UserControl
    {
        private readonly DAL_Service DAL = DAL_Service.Init;
        public StudentControler()
        {
            InitializeComponent();
        }

        private void OnSelectedChange(object sender, SelectionChangedEventArgs e)
        {
            if (sender.Equals(LVStudents) && LVStudents.SelectedItem is Student student)
                DAL.ChoosedStudent(student);
        }
    }
}
