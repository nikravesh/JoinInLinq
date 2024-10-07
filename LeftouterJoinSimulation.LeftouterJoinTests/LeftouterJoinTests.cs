using LeftouterJoinSimulation.LeftouterJoinSample.Models;

namespace LeftouterJoinSimulation.LeftouterJoinTests;

public class LeftouterJoinTests
{

    [Fact]
    public void StudentLeftouterJoinWithStudentWithoutTakeClass()
    {
        //Act
        var joinInstance = JoinTestsMotherObject.JoinInstance;
        var studentsData = JoinTestsMotherObject.GetStudents();
        var coursesData = JoinTestsMotherObject.GetCourses();

        //Arrange
        List<StudentCourse> studentCourses = joinInstance.StudentLeftouterJoin(studentsData, coursesData);

        //Assert
        Assert.NotNull(studentCourses);
        Assert.IsType<List<StudentCourse>>(studentCourses);
    }

    [Fact]
    public void TeacherLeftouterJoinWithStudentWithoutTakeClass()
    {
        //Act
        var joinInstance = JoinTestsMotherObject.JoinInstance;
        var teachersData = JoinTestsMotherObject.GetTeachers();
        var coursesData = JoinTestsMotherObject.GetCourses();

        //Arrange
        List<TeacherCourse> teacherCourses = joinInstance.TeacherCourseLeftouterJoin(teachersData, coursesData);

        //Assert
        Assert.NotNull(teacherCourses);
        Assert.IsType<List<TeacherCourse>>(teacherCourses);
    }
}

public class InnerJoinTests
{
    [Fact]
    public void StudentInnerJoinWhithStudentWithTakeClass()
    {
        //Arrange
        List<Student> students = JoinTestsMotherObject.GetStudents();
        List<Course> courses = JoinTestsMotherObject.GetCourses();

        //Act
        List<StudentCourse> studentCourses = JoinTestsMotherObject.JoinInstance.StudentInnerJoin(students, courses);

        //Assert
        Assert.NotNull(studentCourses);
        Assert.IsType<List<StudentCourse>>(studentCourses);
    }

    [Fact]
    public void TeacherInnerJoinWhithTeacherWithTakeClass()
    {
        //Arrange
        List<Teacher> teachers = JoinTestsMotherObject.GetTeachers();
        List<Course> courses = JoinTestsMotherObject.GetCourses();

        //Act
        List<TeacherCourse> teacherCourses = JoinTestsMotherObject.JoinInstance.TeacherInnerJoin(teachers, courses);

        //Assert
        Assert.NotNull(teacherCourses);
        Assert.IsType<List<TeacherCourse>>(teacherCourses);
    }
}
