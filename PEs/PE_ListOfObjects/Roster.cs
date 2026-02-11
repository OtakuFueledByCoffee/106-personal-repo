using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_ListOfObjects
{
    internal class Roster
    {
        // -------------- Fields --------------
        protected string rosterName;
        List<Student> students;

        // -------------- Properties --------------

        // -------------- Constructors --------------
        /// <summary>
        /// Constructor for the roster of students
        /// </summary>
        /// <param name="name"></param>
        /// <param name="students"></param>
        public Roster(string name, List<Student> students)
        {
            this.rosterName = name;
            this.students = students;
        }

        // -------------- Methods --------------
        public Student SearchByName(string name)
        {
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].Name == name)
                {
                    return students[i];
                }
            }
            return null;
        }

        public void AddStudent(Student s)
        {

        }
    }
}
