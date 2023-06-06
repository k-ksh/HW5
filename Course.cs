//namespace HW5
//{
//    using System;




//    class Course
//    {
//        public string CourseName { get; set; }
//        public string TeacherName { get; set; }
//        public int CourseDuration { get; set; }
//        public int NumberOfStudents { get; set; }

//        public Course(string courseName, string teacherName, int courseDuration, int numberOfStudents)
//        {
//            CourseName = courseName;
//            TeacherName = teacherName;
//            CourseDuration = courseDuration;
//            NumberOfStudents = numberOfStudents;
//        }

//        public void Print()
//        {
//            Console.WriteLine($"Course Name: {CourseName}");
//            Console.WriteLine($"Teacher: {TeacherName}");
//            Console.WriteLine($"Duration: {CourseDuration} hours");
//            Console.WriteLine($"Number of Students: {NumberOfStudents}");
//        }


//        public void AddCourse(string course)
//        {
//            Array.Resize(ref CoursesAttended, CoursesAttended.Length + 1);
//            CoursesAttended[CoursesAttended.Length - 1] = course;
//        }

//        public void DeleteCourse(string course)
//        {
//            int index = Array.IndexOf(CoursesAttended, course);
//            if (index >= 0)
//            {
//                for (int i = index; i < CoursesAttended.Length - 1; i++)
//                {
//                    CoursesAttended[i] = CoursesAttended[i + 1];
//                }
//                Array.Resize(ref CoursesAttended, CoursesAttended.Length - 1);
//            }
//        }
//    }
   
//    }
