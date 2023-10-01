using HR.LeaveManagement.Application.Dto;
using HR.LeaveManagement.Application.Dto.LeaveType;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveTypes.Requests.Commands;

public class CreateLeaveTypeCommand : IRequest<int>
{
    public LeaveTypeDto LeaveTypeDto { get; set; }
}