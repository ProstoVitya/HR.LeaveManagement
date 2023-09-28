using AutoMapper;
using HR.LeaveManagement.Application.Dto.LeaveRequest;
using HR.LeaveManagement.Application.Features.LeaveRequests.Requests.Queries;
using HR.LeaveManagement.Application.Persistence.Contracts;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveRequests.Handlers.Queries;

public class GetLeaveRequestDetailsQueryHandler : IRequestHandler<GetLeaveRequestDetailsQuery, LeaveRequestDto>
{
    private readonly ILeaveRequestRepository _repository;
    private readonly IMapper _mapper;
    
    public GetLeaveRequestDetailsQueryHandler(ILeaveRequestRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<LeaveRequestDto> Handle(GetLeaveRequestDetailsQuery request, CancellationToken cancellationToken)
    {
        var leaveRequest = await _repository.Get(request.Id);
        return _mapper.Map<LeaveRequestDto>(leaveRequest);
    }
}