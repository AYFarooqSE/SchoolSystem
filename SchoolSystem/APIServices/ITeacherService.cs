using SchoolSystem.Models;

namespace SchoolSystem.APIServices
{
    public interface ITeacherService
    {
        public List<TeachersModel> GetAll();
        public void AddTeacherInfo(TeachersModel model);
    }
}
