using AutoMapper;
using AutoMapperPOC.Classes;

namespace AutoMapperPOC.MappingProfile
{
    public class EmployeeMappingProfile : Profile
    {
        public EmployeeMappingProfile()
        {
            CreateMap<Employee, EmployeeDetail>()
                .ForMember(s => s.ID, opt => opt.MapFrom(d => d.ID))
                .ForMember(s => s.EmployeeName, opt => opt.MapFrom(d => d.FirstName + d.LastName))
                .ForMember(s => s.EmployeeCode, opt => opt.MapFrom(d => d.Code))
                .ForMember(s => s.DepartmentName, opt => opt.MapFrom(d => d.Department != null ? d.Department.Name : string.Empty))
                ;

        }
    }
}
