

namespace HW5
{
    using System;
  public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        public string[] CoursesAttended { get; set; }

        public Student(string firstName, string lastName, int age, string city, string[] coursesAttended)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            City = city;
            CoursesAttended = coursesAttended;
        }

        public void Print()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"City: {City}");
            Console.WriteLine("Courses Attended:");
            foreach (var course in CoursesAttended)
            {
                Console.WriteLine(course);
            }
        }

        public void AddStudent()
        {
            int NumberOfStudents = 1;
            NumberOfStudents++;
        }
    }

        static void Main(string[] args)
        {
            // Creating a Student object
            string[] attendedCourses = { "Math", "Science" };
            Student student = new Student("Vincent", "Van Gogh", 20, "New York", attendedCourses);

            // Creating a Course object
            Course course = new Course("Painting", "Jane Smith", 40, 10);

            // Printing student and course information
            student.Print();
            Console.WriteLine();
            course.Print();

            // Adding a course to the student
            student.AddCourse("History");
            Console.WriteLine("\nAfter adding a course:");
            student.Print();

            // Deleting a course from the student
            student.DeleteCourse("Science");
            Console.WriteLine("\nAfter deleting a course:");
            student.Print();

            // Adding a student to the course
            course.AddStudent();
            Console.WriteLine("\nAfter adding a student to the course:");
            course.Print();
        }
    

    class Course
    {
        public string CourseName { get; set; }
        public string TeacherName { get; set; }
        public int CourseDuration { get; set; }
        public int NumberOfStudents { get; set; }

        public Course(string courseName, string teacherName, int courseDuration, int numberOfStudents)
        {
            CourseName = courseName;
            TeacherName = teacherName;
            CourseDuration = courseDuration;
            NumberOfStudents = numberOfStudents;
        }

        public void Print()
        {
            Console.WriteLine($"Course Name: {CourseName}");
            Console.WriteLine($"Teacher: {TeacherName}");
            Console.WriteLine($"Duration: {CourseDuration} hours");
            Console.WriteLine($"Number of Students: {NumberOfStudents}");
        }


        public void AddCourse(string course)
        {

            int CoursesAttended;
            Array.Resize(ref CoursesAttended, CoursesAttended.Length + 1);
            CoursesAttended[CoursesAttended.Length - 1] = course;
        }

        public void DeleteCourse(string course)
        {
            int index = Array.IndexOf(CoursesAttended, course);
            if (index >= 0)
            {
                for (int i = index; i < CoursesAttended.Length - 1; i++)
                {
                    CoursesAttended[i] = CoursesAttended[i + 1];
                }
                Array.Resize(ref CoursesAttended, CoursesAttended.Length - 1);
            }
        }
    }

}
