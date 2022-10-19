using WebApiEFAssDay1.DTOs;
using WebApiEFAssDay1.Models;

namespace WebApiEFAssDay1.Services.Interface
{
    public interface IStudentService
    {   
        IEnumerable<Student> GetAll();
        AddStudentResponse Create(AddStudentRequest createModel);
        StudentViewModel Update(UpdateStudentRequest updateStudentRequest);
        StudentViewModel Delete(DeleteStudentRequest deleteStudentRequest);
    }
}