using HR.LeaveManagement.Application.Dto;
using HR.LeaveManagement.Application.Dto.LeaveAllocation;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveAllocations.Requests.Queries;

public class GetLeaveAllocationDetailQuery : IRequest<LeaveAllocationDto>
{
    public int Id { get; set; }
}