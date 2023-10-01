using HR.LeaveManagement.Application.Dto.LeaveRequest;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveRequests.Requests.Commands;

public class CreateLeaveRequestCommand : IRequest<int>
{
    public CreateLeaveRequestDto LeaveRequestDto { get; set; }
}

