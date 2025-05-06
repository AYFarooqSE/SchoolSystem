using AutoMapper;
using SchoolSystem.APIServices;
using SchoolSystem.Interfaces;

namespace SchoolSystem.MapperProfiles
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<IStudentService, StudentService>();
        }
    }
}
