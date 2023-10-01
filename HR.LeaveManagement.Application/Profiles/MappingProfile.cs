using AutoMapper;
using HR.LeaveManagement.Application.Dto;
using HR.LeaveManagement.Application.Dto.LeaveAllocation;
using HR.LeaveManagement.Application.Dto.LeaveRequest;
using HR.LeaveManagement.Application.Dto.LeaveType;
using HR.LeaveManagement.Domain;

namespace HR.LeaveManagement.Application.Profiles;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<LeaveRequest, LeaveRequestDto>()
            .ReverseMap();
        CreateMap<LeaveRequest, LeaveRequestListDto>()
            .ReverseMap();
        CreateMap<LeaveAllocation, LeaveAllocationDto>()
            .ReverseMap();
        CreateMap<LeaveType, LeaveTypeDto>()
            .ReverseMap();
    }
}