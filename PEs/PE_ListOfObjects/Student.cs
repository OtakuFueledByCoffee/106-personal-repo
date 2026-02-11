using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_ListOfObjects
{
    internal class Student
    {
        // -------------- Protected Fields --------------
        protected string name;
        protected string major;
        protected int year;

        // -------------- Public Properties --------------
        /// <summary>
        /// Read-only property
        /// </summary>
        public string Name
        {
            get
            {
                return name;
            }
        }

        /// <summary>
        /// Read-only property
        /// </summary>
        public string Major
        {
            get
            {
                return major;
            }
        }

        /// <summary>
        /// Read-only proprety for year-level
        /// </summary>
        public int Year
        {
            get
            {
                return year;
            }
        }

        // -------------- Constructors --------------
        /// <summary>
        /// Parameterized constructor for student data 
        /// </summary>
        public Student(string name, string major, int year)
        {
            this.name = name;
            this.major = major;
            this.year = year;
        }

        // -------------- Methods --------------
        /// <summary>
        /// Method to return a string of student's data
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Name: {name}\n" +
                $"Major: {major}\n" +
                $"Year: {year} year";
        }
    }
}
