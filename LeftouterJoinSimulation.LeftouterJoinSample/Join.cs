using LeftouterJoinSimulation.LeftouterJoinSample.Data;
using LeftouterJoinSimulation.LeftouterJoinSample.Models;

namespace LeftouterJoinSimulation.LeftouterJoinSample;
public class Join
{
    private List<Student> _students;
    private List<Teacher> _teachers;
    private List<Course> _courses;

    public Join()
    {
        _students = SeedData.GetStudents();
        _teachers = SeedData.GetTeachers();
        _courses = SeedData.GetCourses();
    }

    public List<StudentCourse> StudentLeftouterJoin() =>
        _students.GroupJoin(_courses, s => s.CourseId, c => c.Id, (s, c) =>
            new
            {
                s.Id,
                s.CourseId,
                s.FirstName,
                s.LastName,
                Courses = c
            }).SelectMany(s => s.Courses.DefaultIfEmpty(), (s, c) =>
            {
                return new StudentCourse
                {
                    Id = s.Id,
                    CourseId = s.CourseId,
                    FirstName = s.FirstName,
                    LastName = s.LastName,
                    CourseName = c?.CourseName ?? "-----"
                };
            }).ToList();

    public List<TeacherCourse> TeacherCourseLeftouterJoin() =>
        _teachers.GroupJoin(_courses, t => t.CourseId, c => c.Id, (t, c) =>
        new
        {
            t.Id,
            t.CourseId,
            t.FirstName,
            t.LastName,
            Courses = c
        }).SelectMany(t => t.Courses.DefaultIfEmpty(), (t, c) =>
        {
            return new TeacherCourse
            {
                Id = t.Id,
                CourseId = t.CourseId,
                FirstName = t.FirstName,
                LastName = t.LastName,
                CourseName = c?.CourseName ?? "-----"
            };
        }).ToList();
}
