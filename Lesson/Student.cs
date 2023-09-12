using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson
{
    public class Student:IComparable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public StudentCard StudentCard { get; set; }

        public int CompareTo(object obj)
        {
            if(obj is Student)
            return BirthDate.CompareTo((obj as Student).BirthDate);
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
 
    }
}
