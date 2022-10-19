using WebApiEFAssDay1.DTOs;
using WebApiEFAssDay1.Models;
using WebApiEFAssDay1.Repositories.Interface;
using WebApiEFAssDay1.Services.Interface;

namespace WebApiEFAssDay1.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public AddStudentResponse Create(AddStudentRequest createModel)
        {
            var createStudent = new Student
            {
                FirstName = createModel.FirstName,
                LastName = createModel.LastName,
                City = createModel.City,
                State = createModel.State
            };
            var student = _studentRepository.Create(createStudent);
            _studentRepository.SaveChanges();

            return new AddStudentResponse
            {
                Id = student.Id,
                FirstName = student.FirstName
            };
        }

        public StudentViewModel Delete(DeleteStudentRequest deleteStudentRequest)
        {
            var studentTemp = _studentRepository.Get(x => x.Id == deleteStudentRequest.Id);
            if (studentTemp != null)
            {
                _studentRepository.Delete(studentTemp);
                _studentRepository.SaveChanges();
            }
            return null;
        }

        public IEnumerable<Student> GetAll()
        {
            return _studentRepository.GetAll(x => true);
        }

        public StudentViewModel Update(UpdateStudentRequest updateStudentRequest)
        {
            var studentTemp = _studentRepository.Get(x => x.Id == updateStudentRequest.Id);
            if (studentTemp != null)
            {
                studentTemp.FirstName = updateStudentRequest.FirstName;
                studentTemp.LastName = updateStudentRequest.LastName;
                studentTemp.City = updateStudentRequest.City;
                studentTemp.State = updateStudentRequest.State;
                _studentRepository.SaveChanges();
            }
            _studentRepository.Update(studentTemp);
            
            return null;
        }
    }
}