using LeftouterJoinSimulation.LeftouterJoinSample.Models;

namespace LeftouterJoinSimulation.LeftouterJoinTests;

public class LeftouterJoinTests
{

    [Fact]
    public void StudentLeftouterJoinWithStudentWithoutTakeClass()
    {
        //Act
        var joinInstance = LeftouterJoinTestsMotherObject.JoinInstance;
        var studentsData = LeftouterJoinTestsMotherObject.GetStudents();
        var coursesData = LeftouterJoinTestsMotherObject.GetCourses();

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
        var joinInstance = LeftouterJoinTestsMotherObject.JoinInstance;
        var teachersData = LeftouterJoinTestsMotherObject.GetTeachers();
        var coursesData = LeftouterJoinTestsMotherObject.GetCourses();

        //Arrange
        List<TeacherCourse> teacherCourses = joinInstance.TeacherCourseLeftouterJoin(teachersData, coursesData);

        //Assert
        Assert.NotNull(teacherCourses);
        Assert.IsType<List<TeacherCourse>>(teacherCourses);
    }
}
