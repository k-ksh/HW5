//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace HW5
//{
//    class Constructors
//    {
//        static void Main(string[] args)
//        {
//            // Creating a Student object
//            string[] attendedCourses = { "Math", "Science" };
//            Student student = new Student("Vincent", "Van Gogh", 20, "New York", attendedCourses);

//            // Creating a Course object
//            Course course = new Course("Painting", "Jane Smith", 40, 10);

//            // Printing student and course information
//            student.Print();
//            Console.WriteLine();
//            course.Print();

//            // Adding a course to the student
//            student.AddCourse("History");
//            Console.WriteLine("\nAfter adding a course:");
//            student.Print();

//            // Deleting a course from the student
//            student.DeleteCourse("Science");
//            Console.WriteLine("\nAfter deleting a course:");
//            student.Print();

//            // Adding a student to the course
//            course.AddStudent();
//            Console.WriteLine("\nAfter adding a student to the course:");
//            course.Print();
//        }
//    }

//}
