using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
        public Roster(string name, List<Student> students = new List<Student>)
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
            return null!;
        }

        /// <summary>
        /// Method to add a student to the roster without user input
        /// </summary>
        /// <param name="s"></param>
        public void AddStudent(Student s)
        {
            // Checkign if student name already exists
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].Name == s.Name)
                {
                    students.Add(s);

                    // Print confirmation & return to end
                    Console.WriteLine($"Added {s.Name} to the roster.");

                    return;
                }
            }

            // Confirmation message & return to end
            Console.WriteLine($"Unable to add {s.Name} to roster: {s.Name} already exists.");

            return;
        }

        /// <summary>
        /// Overload method (not really, the opposite technically) to add a custom student to the rester
        /// by prompting user input
        /// </summary>
        /// <returns></returns>
        public Student AddStudent()
        {
            // Declaring values
            string name;
            string major;
            string yearAsString;
            int year;
            Student student;

            // Ask user for information
            Console.Write("Full Name: ");
            name = Console.ReadLine()!;
            Console.Write("Major: ");
            major = Console.ReadLine()!;
            Console.WriteLine("Year Level: ");
            yearAsString = Console.ReadLine()!;

            // Checking if year inputted is a valid integer
            while (!int.TryParse(yearAsString, out year))
            {
                Console.Write("Invalid input: Integers only. ");
                yearAsString = Console.ReadLine()!;
            }

            // Create new Student object
            student = new Student(name, major, year);

            // Check if student exists in roster
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].Name == student.Name)
                {
                    // Adding student to roster
                    students.Add(student);

                    // Print confirmation 
                    Console.WriteLine($"Added {student.Name} to to the roster.");

                    // Return student object
                    return student;
                }
            }

            // Print confirmation if student is already in roster
            Console.WriteLine($"Unable to add {student.Name} to roster: {student.Name} already exists.");

            // Return null
            return null!;
        }

        /// <summary>
        /// Method to display the roster of students
        /// </summary>
        public void DisplayRoster()
        {
            // Printing roster information
            Console.WriteLine($"Roster: {students.Count} students");
            
            // For loop to print all student information from list
            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine($"\tStudent #{i+1}:");
                students[i].ToString();
            }
        }
    }
}
