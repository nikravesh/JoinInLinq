using LeftouterJoinSimulation.LeftouterJoinSample.Models;

namespace LeftouterJoinSimulation.LeftouterJoinSample.Data;

public class SeedData
{
    public static List<Student> GetStudents() =>
        [
            new Student
            {
                FirstName = "Alireza",
                LastName = "Nikravesh",
                Id = 1,
                CourseId = 1
            },
            new Student
            {
                FirstName = "Alireza",
                LastName = "Nikravesh",
                Id = 1,
                CourseId = 2
            },
            new Student
            {
                FirstName = "Alireza",
                LastName = "Nikravesh",
                Id = 1,
                CourseId = 3
            },
            new Student
            {
                FirstName = "Alireza",
                LastName = "Nikravesh",
                Id = 1,
                CourseId = 4
            },
            new Student
            {
                FirstName = "Matin",
                LastName = "Nikravesh",
                Id = 1,
                CourseId = 1
            },
            new Student
            {
                FirstName = "Matin",
                LastName = "Nikravesh",
                Id = 1,
                CourseId = 3
            },
            new Student
            {
                FirstName = "Jack",
                LastName = "Wilson",
                Id = 1,
                CourseId = 3
            },
            new Student
            {
                FirstName = "Jack",
                LastName = "Wilson",
                Id = 1,
                CourseId = 4
            },
            new Student
            {
                FirstName = "Oliver",
                LastName = "Miller",
                Id = 1,
                CourseId = 1
            },
            new Student
            {
                FirstName = "William",
                LastName = "Smith",
                Id = 2
            }
        ];

    public static List<Teacher> GetTeachers() =>
        [
            new Teacher
            {
                FirstName = "John",
                LastName = "Walsh",
                Id = 1,
                CourseId = 1
            },
            new Teacher
            {
                FirstName = "John",
                LastName = "Walsh",
                Id = 1,
                CourseId = 4
            },
            new Teacher
            {
                FirstName = "John",
                LastName = "Walsh",
                Id = 1,
                CourseId = 3
            },
            new Teacher
            {
                FirstName = "Keyvin",
                LastName = "Evans",
                Id = 1
            },
            new Teacher
            {
                FirstName = "Amelia",
                LastName = "Rodriguez",
                Id = 1,
                CourseId = 2
            },
            new Teacher
            {
                FirstName = "Martin",
                LastName = "Miller",
                Id = 1,
                CourseId = 3
            },
            new Teacher
            {
                FirstName = "Bill",
                LastName = "Roberts",
                Id = 1,
                CourseId = 3
            },
            new Teacher
            {
                FirstName = "Bill",
                LastName = "Roberts",
                Id = 1,
                CourseId = 2
            }
        ];

    public static List<Course> GetCourses() =>
        [
            new Course
            {
                Id = 1,
                CourseName = "Asp.Net"
            },
            new Course
            {
                Id = 2,
                CourseName = "SQL Server"
            },
            new Course
            {
                Id = 3,
                CourseName = "EF core"
            },
            new Course
            {
                Id = 4,
                CourseName = "OAuth2"
            }
        ];
}