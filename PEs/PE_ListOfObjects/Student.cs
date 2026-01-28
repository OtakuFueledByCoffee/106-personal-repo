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

    }
}
