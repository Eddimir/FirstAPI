using System.Collections.Generic;

public interface IClassroomService
{
    bool AddStudents(List<StudentModel> students);
    bool AddStudent(StudentModel student);
    bool UpdateStudent(StudentModel student);
    bool UpdateStudents(List<StudentModel> students);
    bool DeleteStudents(List<StudentModel> students);
    IEnumerable<StudentModel> GetAllStudents();
}