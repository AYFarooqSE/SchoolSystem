using AutoMapper;
using SchoolSystem.Interfaces;
using SchoolSystem.Models.StudentModels;
using SchoolSystem.Requests;

namespace SchoolSystem.APIServices
{
    public class StudentService(IMapper mapper):IStudentService
    {
        public async Task<bool> AddStudent(AddStudentRequest request)
        {
            var model = mapper.Map<StudentModel>(request);

            return true;
        }
    }
}
