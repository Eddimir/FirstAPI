using System.Collections.Generic;
using System.Linq;

public class ClassroomService : IClassroomService
{
    private List<StudentModel> _students;
    public ClassroomService()
    {
        _students = new List<StudentModel>();
    }
    public bool AddStudent(StudentModel student)
    {
        if (student != null)
        {
            _students.Add(student);
            return true;
        }
        return false;
    }

    public bool AddStudents(List<StudentModel> students)
    {
        if (students.Count > 0)
        {
            _students.AddRange(students);
            return true;
        }
        return false;
    }
    public bool UpdateStudents(List<StudentModel> students)
    {
        if (students.Count > 0)
        {
            foreach (var item in students)
            {
                var std = _students.FirstOrDefault(x => x.Id == item.Id);
                if (std != null)
                {
                    std.Name = item.Name;
                    std.Grade = item.Grade;
                }
            }

            return true;
        }
        return false;
    }
    public bool DeleteStudents(List<StudentModel> students)
    {
        if (students.Count > 0)
        {
            foreach (var item in students)
            {
                var std = _students.FirstOrDefault(x => x.Id == item.Id);
                if (std != null)
                {
                    _students.Remove(std);
                }
            }

            return true;
        }
        return false;
    }

    public bool UpdateStudent(StudentModel student)
    {
        if (student != null)
        {
            var std = _students.FirstOrDefault(x=>x.Id == student.Id);
            if (std != null)
            {
                std.Name = student.Name;
                std.Grade = student.Grade;
            }
            return true;
        }
        return false;
    }
    public IEnumerable<StudentModel> GetAllStudents()
    {
        return _students;
    }
}