using SchoolSystem.Requests;

namespace SchoolSystem.Interfaces
{
    public interface IStudentService
    {
        Task<bool> AddStudent(AddStudentRequest addStudentRequest);
    }
}
