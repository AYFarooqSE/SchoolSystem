using AutoMapper;
using SchoolSystem.Interfaces;
using SchoolSystem.Services;

namespace SchoolSystem.MapperProfiles
{
    public class MapperProfile:Profile
    {
        public MapperProfile() 
        {
            CreateMap<IStudentService, StudentService>();
        }
    }
}
