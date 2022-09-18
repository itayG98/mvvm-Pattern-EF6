using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Linq;

namespace DimitryExercise2
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {

            //using (var data = DAL_Service.Init.data)
            //{
            //    List<Person> people = new List<Person>();
            //    people.Add(new Student() { Name = "Itay", Grade = 96, CoursesLearn = Course.Sql | Course.CSharp | Course.OOP, BirthDate = new DateTime(1998, 2, 5) });
            //    people.Add(new Student() { Name = "Josh", Grade = 92, CoursesLearn = Course.Sql | Course.CSharp, BirthDate = new DateTime(1999, 3, 3) });
            //    people.Add(new Student() { Name = "Alex", Grade = 90, CoursesLearn = Course.Sql | Course.CSharp, BirthDate = new DateTime(1998, 6, 9) });
            //    people.Add(new Student() { Name = "Daniel", Grade = 88, CoursesLearn = Course.OOP | Course.Solid | Course.CSharp, BirthDate = new DateTime(1998, 12, 15) });
            //    people.Add(new Teacher() { Name = "Daniel", CoursesTeach = Course.OOP | Course.Solid | Course.CSharp | Course.Azure, BirthDate = new DateTime(1978, 12, 15) });
            //    people.Add(new Teacher() { Name = "Ron", CoursesTeach = Course.OOP | Course.Solid | Course.CSharp, BirthDate = new DateTime(1990, 12, 15) });
            //    people.Add(new Teacher() { Name = "Ron", CoursesTeach = Course.OOP | Course.Solid | Course.CSharp | Course.Azure | Course.Html, BirthDate = new DateTime(1990, 12, 15) });
            //    people.Add(new Teacher() { Name = "Dimitry", CoursesTeach = Course.OOP | Course.Solid | Course.CSharp | Course.Azure | Course.Html | Course.JavaScript, BirthDate = new DateTime(1990, 12, 15) });


            //    data.People.AddRange(people);
            //    data.SaveChanges();
            //}
            base.OnStartup(e);
        }
    }

}
