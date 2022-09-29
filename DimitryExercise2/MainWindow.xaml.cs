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

namespace DimitryExercise2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        readonly DAL_Service DAL = DAL_Service.Init;
        public MainWindow()
        {

            InitializeComponent();
            DAL.RefreshListsEvent?.Invoke();

            //List<Student> students = new List<Student>
            //{
            //    new Student() {Name="John Albert",BirthDate= new DateTime(1998,10,10) ,Grade=99,Courses= Courses.Sql|Courses.CSharp },
            //    new Student() {Name="John Dohe",BirthDate= new DateTime(2000,3,5) ,Grade=70,Courses= Courses.Sql|Courses.CSharp },
            //    new Student() {Name="Ariel Albert",BirthDate= new DateTime(1998,10,5) ,Grade=80, Courses = Courses.Sql | Courses.CSharp|Courses.OOP},
            //    new Student() {Name="Rihana R-James",BirthDate= new DateTime(1990,2,10) ,Grade=100,Courses =Courses.OOP},
            //    new Student() {Name="Shon Mandes",BirthDate= new DateTime(1996,12,12) ,Grade=87,Courses =Courses.AspNet}
            //};
            //List<Teacher> teachers = new List<Teacher>() {
            //    new Teacher() {Name="Avi Dayan" ,Courses= Courses.Sql|Courses.CSharp },
            //    new Teacher() {Name="Ron Amir" ,Courses= Courses.Azure|Courses.Css|Courses.OOP },
            //    new Teacher() {Name="Yoel Geva" ,Courses= Courses.Html|Courses.AspNet|Courses.Sql }
            //};
            //DAL.AddOrUpdatePeople(teachers.ToArray());
            //DAL.AddOrUpdatePeople(students.ToArray());
            //teachers[0].Students.Add(students[0]);
            //teachers[0].Students.Add(students[1]);
            //teachers[0].Students.Add(students[2]);
            //teachers[1].Students.Add(students[2]);
            //teachers[1].Students.Add(students[3]);
            //teachers[2].Students.Add(students[2]);
            //teachers[2].Students.Add(students[3]);

            //DAL.AddOrUpdatePeople(teachers.ToArray());
            //DAL.AddOrUpdatePeople(students.ToArray());


        }
    }
}
