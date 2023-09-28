using HR.LeaveManagement.Application.Dto.LeaveRequest;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveRequests.Requests.Queries;

public class GetLeaveRequestListQuery : IRequest<List<LeaveRequestDto>> { }