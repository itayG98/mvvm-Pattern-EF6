using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DimitryExercise2
{
    public class DAL_Service
    {
        private static readonly DAL_Service _dataService = new DAL_Service();

        public  ModelContainer data;

        public static DAL_Service Init
        {
            get
            {
                if (_dataService == null) 
                    return new DAL_Service();
                else return _dataService;
            }
        }
        private DAL_Service()
        {
            data = new ModelContainer();
        }

        public IEnumerable<Teacher> GetTeachers() 
        {
            return (data.People.OfType<Teacher>());
        }

        public IEnumerable<Student> GetStudents()
        {
            return (data.People.OfType<Student>());
        }

        public void AddPerson(Person p)
        {
            data.People.Add(p);
            data.SaveChanges();
        }
    }
}
