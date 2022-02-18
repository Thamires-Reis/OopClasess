

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStudentMarks01.Models
{
    
    
    public class School
    {

        public string Name { get; set; }

        public List<Student> listOfStudents { get; set; }

        public School(string _name)
        {
            Name = _name;
           
            listOfStudents = new List<Student>();
        }

        public override string ToString()
        {
            return $"School is {Name}";
        }

        public void DisplayStudents()
        {
           
            foreach (Student currentStudentInList in listOfStudents)
            {

                Console.WriteLine(currentStudentInList.ToString());

                currentStudentInList.DisplaySubjects();
            }

        }

    }
}