using AutoMapper;
using ESSCD_API.Models;

namespace ESSCD_API.DataService.AutoMapper
{
    public class MappingProfile : Profile
    {
       public MappingProfile() 
       {
            CreateMap<Shifts, EmployeeShiftDTO>()
             .ForMember(dest => dest.EmployeeId, opt => opt.MapFrom(src => src.Employee.Id))
             .ForMember(dest => dest.EmployeeName, opt => opt.MapFrom(src => src.Employee.EmployeeName))
             .ForMember(dest => dest.EmployeeEmailId, opt => opt.MapFrom(src => src.Employee.EmployeeEmailId))
             .ForMember(dest => dest.EmployeeDepartment, opt => opt.MapFrom(src => src.Employee.EmployeeDepartment))
             .ForMember(dest => dest.ShiftStartTime, opt => opt.MapFrom(src => src.StartDateTime))
             .ForMember(dest => dest.ShiftEndTime, opt => opt.MapFrom(src => src.EndDateTime));
        }
    }
}
