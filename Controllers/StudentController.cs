using Microsoft.AspNetCore.Mvc;
using WebApiEFAssDay1.DTOs;
using WebApiEFAssDay1.Models;
using WebApiEFAssDay1.Services.Interface;
namespace WebApiEFAssDay1.Controllers;

[ApiController]
[Route("[controller]")]
public class StudentController : ControllerBase
{
    private readonly ILogger<StudentController> _logger;
    private readonly IStudentService _studentService;

    public StudentController(IStudentService studentServices)
    {
        _studentService = studentServices;
    }

    [HttpGet]
    public IEnumerable<Student> GetAll()
    {
        return _studentService.GetAll();
    }

    [HttpPost]
    public AddStudentResponse Add([FromBody] AddStudentRequest addRequest)
    {
        return _studentService.Create(addRequest);
    }

    [HttpPut]
    public StudentViewModel Update([FromBody] UpdateStudentRequest updateRequest)
    {
        return _studentService.Update(updateRequest);
    }

    [HttpDelete]
    public StudentViewModel Delete([FromBody] DeleteStudentRequest deleteStudentRequest)
    {
        return _studentService.Delete(deleteStudentRequest);
    }
}
