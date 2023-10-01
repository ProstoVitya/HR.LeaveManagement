using HR.LeaveManagement.Application.Dto;
using HR.LeaveManagement.Application.Dto.LeaveType;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveTypes.Requests.Queries;

public class GetLeaveTypeListQuery : IRequest<List<LeaveTypeDto>> { }