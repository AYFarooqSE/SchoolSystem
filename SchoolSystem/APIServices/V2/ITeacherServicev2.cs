using SchoolSystem.Models;

namespace SchoolSystem.APIServices.V2
{
    public interface ITeacherServicev2
    {
        Task<List<TeachersModel>> GetAll();
        Task<TeachersModel> GetByID(int? ID);

        Task<bool> AddTeacherInfo(TeachersModel model);

        Task<bool> DeleteRecord(TeachersModel model);
    }
}
