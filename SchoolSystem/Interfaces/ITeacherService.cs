using SchoolSystem.Models;

namespace SchoolSystem.Interfaces
{
    public interface ITeacherService
    {
        public List<TeachersModel> GetAll();
    }
}
