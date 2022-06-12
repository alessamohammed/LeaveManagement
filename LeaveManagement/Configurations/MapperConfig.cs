using AutoMapper;
using LeaveManagement.Data;
using LeaveManagement.Models;

namespace LeaveManagement.Configurations;

public class MapperConfig: Profile
{
    public MapperConfig()
    {
        CreateMap<LeaveType, LeaveTypeVM>().ReverseMap();
        
    }
}