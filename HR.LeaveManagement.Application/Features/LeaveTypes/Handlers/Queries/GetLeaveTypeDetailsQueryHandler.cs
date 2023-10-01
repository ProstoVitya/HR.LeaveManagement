using AutoMapper;
using HR.LeaveManagement.Application.Dto;
using HR.LeaveManagement.Application.Dto.LeaveType;
using HR.LeaveManagement.Application.Features.LeaveTypes.Requests.Queries;
using HR.LeaveManagement.Application.Persistence.Contracts;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveTypes.Handlers.Queries;

public class GetLeaveTypeDetailsQueryHandler : IRequestHandler<GetLeaveTypeDetailQuery, LeaveTypeDto>
{
    private readonly ILeaveTypeRepository _leaveTypeRepository;
    private readonly IMapper _mapper;
    
    public GetLeaveTypeDetailsQueryHandler(ILeaveTypeRepository leaveTypeRepository, IMapper mapper)
    {
        _leaveTypeRepository = leaveTypeRepository;
        _mapper = mapper;
    }

    public async Task<LeaveTypeDto> Handle(GetLeaveTypeDetailQuery query, CancellationToken cancellationToken)
    {
        var leaveType = await _leaveTypeRepository.Get(query.Id);
        return _mapper.Map<LeaveTypeDto>(leaveType);
    }
}