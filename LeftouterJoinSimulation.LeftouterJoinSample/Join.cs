using LeftouterJoinSimulation.LeftouterJoinSample.Models;

namespace LeftouterJoinSimulation.LeftouterJoinSample;
public class Join
{
    public List<StudentCourse> StudentLeftouterJoin(List<Student> students, List<Course> courses) =>
        students.GroupJoin(courses, s => s.CourseId, c => c.Id, (s, c) =>
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

    public List<StudentCourse> StudentInnerJoin(List<Student> students, List<Course> courses) =>
        students.Join(courses, s => s.CourseId, c => c.Id, (s, c) =>
            new StudentCourse
            {
                Id = s.Id,
                CourseId = s.CourseId,
                FirstName = s.FirstName,
                LastName = s.LastName,
                CourseName = c.CourseName
            }).ToList();

    public List<TeacherCourse> TeacherCourseLeftouterJoin(List<Teacher> teachers, List<Course> courses) =>
        teachers.GroupJoin(courses, t => t.CourseId, c => c.Id, (t, c) =>
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

    public List<StudentCourse> TeacherInnerJoin(List<Teacher> teachers, List<Course> courses)
    {
        throw new NotImplementedException();
    }
}
