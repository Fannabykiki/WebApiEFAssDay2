using WebApiEFAssDay1.Models;
using WebApiEFAssDay1.Repositories;
using WebApiEFAssDay1.Repositories.Interface;
namespace StudentManagement.Repositories;

public class StudentRepository : BaseRepository<Student>, IStudentRepository
{
    public StudentRepository(StudentContext context) : base(context)
    {
    }
}