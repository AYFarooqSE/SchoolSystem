using AutoMapper;
using SchoolSystem.APIServices;
using SchoolSystem.Interfaces;
using SchoolSystem.Models.StudentModels;
using SchoolSystem.Requests;

namespace SchoolSystem.MapperProfiles
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<AddStudentRequest, StudentModel>().ReverseMap();
        }
    }
}
