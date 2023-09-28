using AutoMapper;
using HR.LeaveManagement.Application.Dto.LeaveRequest;
using HR.LeaveManagement.Application.Features.LeaveRequests.Requests.Queries;
using HR.LeaveManagement.Application.Persistence.Contracts;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveRequests.Handlers.Queries;

public class GetLeaveRequestListQueryHandler : IRequestHandler<GetLeaveRequestListQuery, List<LeaveRequestDto>>
{
    private readonly ILeaveRequestRepository _repository;
    private readonly IMapper _mapper;
    
    public GetLeaveRequestListQueryHandler(ILeaveRequestRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<List<LeaveRequestDto>> Handle(GetLeaveRequestListQuery request, CancellationToken cancellationToken)
    {
        var leaveRequests = await _repository.GetAll();
        return _mapper.Map<List<LeaveRequestDto>>(leaveRequests);
    }
}