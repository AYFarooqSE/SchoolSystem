using SchoolSystem.Models;

namespace SchoolSystem.Interfaces
{
    public interface ITeacherService
    {
        public List<TeachersModel> GetAll();
        public TeachersModel GetByID(int? ID);
        public void AddTeacherInfo(TeachersModel model);
        public int DeleteRecord(TeachersModel model);
    }
}
