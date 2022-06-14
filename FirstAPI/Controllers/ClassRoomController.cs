using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

[ApiController]
[Route("api/Classroom/Student")]
public class ClassRoomController : ControllerBase
{
    private IClassroomService _classroomService;

    public ClassRoomController(IClassroomService classroomService)
    {
        _classroomService = classroomService;
    }
   /* [HttpPost]
    //..student
    public ActionResult<bool> AddStudent(StudentModel student)
    {
        if (_classroomService == null)
        {
            return NotFound();
        }
        var result = _classroomService.AddStudent(student);
        return result;
    }*/
    [HttpPost]
    //..student
    public ActionResult<bool> AddStudents(List<StudentModel> student)
    {
        if (_classroomService == null)
        {
            return NotFound();
        }
        var result = _classroomService.AddStudents(student);
        return result;
    }

    [HttpPut]
    //..student
    public ActionResult<bool> EditStudents(List<StudentModel> student)
    {
        if (_classroomService == null)
        {
            return NotFound();
        }
        var result = _classroomService.UpdateStudents(student);
        return result;
    }
    [HttpDelete]
    //..student
    public ActionResult<bool> DeleteStudents(List<StudentModel> student)
    {
        if (_classroomService == null)
        {
            return NotFound();
        }
        var result = _classroomService.DeleteStudents(student);
        return result;
    }
    [HttpGet]
    public ActionResult<IEnumerable<StudentModel>> GetStudents()
    {
        if (_classroomService == null)
        {
            return NotFound();
        }
        var result = _classroomService.GetAllStudents().ToList();
        return result;
    }
}