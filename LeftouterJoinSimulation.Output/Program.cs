using LeftouterJoinSimulation.LeftouterJoinSample;
using LeftouterJoinSimulation.LeftouterJoinSample.Data;
using LeftouterJoinSimulation.LeftouterJoinSample.Models;

Join leftouterJoinSample = new();
List<StudentCourse> studentCourse = leftouterJoinSample.StudentLeftouterJoin(SeedData.GetStudents(),SeedData.GetCourses());

Console.Write("".PadLeft(49, '-'));
Console.Write("Students Leftouter join");
Console.WriteLine("".PadLeft(49, '-'));

foreach (StudentCourse studentCourseItem in studentCourse)
{
    Console.WriteLine($"{studentCourseItem.FirstName} {studentCourseItem.LastName} has course : {studentCourseItem.CourseName}");
}

List<StudentCourse> studentInnerCourse = leftouterJoinSample.StudentInnerJoin(SeedData.GetStudents(), SeedData.GetCourses());

Console.Write("".PadLeft(49, '-'));
Console.Write("Students Inner join");
Console.WriteLine("".PadLeft(49, '-'));

foreach (StudentCourse studentCourseItem in studentInnerCourse)
{
    Console.WriteLine($"{studentCourseItem.FirstName} {studentCourseItem.LastName} has course : {studentCourseItem.CourseName}");
}

Console.Write("".PadLeft(49, '-'));
Console.Write("Teachers Leftouter join");
Console.WriteLine("".PadLeft(49, '-'));

List<TeacherCourse> teacherCourses = leftouterJoinSample.TeacherCourseLeftouterJoin(SeedData.GetTeachers(), SeedData.GetCourses());

foreach (TeacherCourse teacherCourseItem in teacherCourses)
{
    Console.WriteLine($"{teacherCourseItem.FirstName} {teacherCourseItem.LastName} has course : {teacherCourseItem.CourseName}");
}

Console.Write("".PadLeft(49, '-'));
Console.Write("Teachers Inner join");
Console.WriteLine("".PadLeft(49, '-'));

List<TeacherCourse> teacherInnerCourses = leftouterJoinSample.TeacherInnerJoin(SeedData.GetTeachers(), SeedData.GetCourses());

foreach (TeacherCourse teacherCourseItem in teacherInnerCourses)
{
    Console.WriteLine($"{teacherCourseItem.FirstName} {teacherCourseItem.LastName} has course : {teacherCourseItem.CourseName}");
}