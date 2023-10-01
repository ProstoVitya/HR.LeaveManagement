using AutoMapper;
using HR.LeaveManagement.Application.Dto;
using HR.LeaveManagement.Application.Dto.LeaveAllocation;
using HR.LeaveManagement.Application.Features.LeaveAllocations.Requests.Queries;
using HR.LeaveManagement.Application.Persistence.Contracts;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveAllocations.Handlers.Queries;

public class GetLeaveAllocationDetailQueryHandler : IRequestHandler<GetLeaveAllocationDetailQuery, LeaveAllocationDto>
{
    private readonly ILeaveAllocationRepository _repository;
    private readonly IMapper _mapper;
    
    public GetLeaveAllocationDetailQueryHandler(ILeaveAllocationRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<LeaveAllocationDto> Handle(GetLeaveAllocationDetailQuery request, CancellationToken cancellationToken)
    {
        var leaveAllocation = await _repository.Get(request.Id);
        return _mapper.Map<LeaveAllocationDto>(leaveAllocation);
    }
}