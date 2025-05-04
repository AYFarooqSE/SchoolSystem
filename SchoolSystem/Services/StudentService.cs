using AutoMapper;
using SchoolSystem.Interfaces;
using SchoolSystem.Models.StudentModels;
using SchoolSystem.Requests;

namespace SchoolSystem.Services
{
    public class StudentService(IMapper mapper):IStudentService
    {
        public async Task<bool> AddStudent(AddStudentRequest addStudentRequest) 
        {
            var model = mapper.Map<StudentModel>(addStudentRequest);
            return false;
        }
    }
}
