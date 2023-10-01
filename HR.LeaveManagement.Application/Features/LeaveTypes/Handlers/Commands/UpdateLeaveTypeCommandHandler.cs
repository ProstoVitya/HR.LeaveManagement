﻿using AutoMapper;
using HR.LeaveManagement.Application.Features.LeaveTypes.Requests.Commands;
using HR.LeaveManagement.Application.Persistence.Contracts;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveTypes.Handlers.Commands;

public class UpdateLeaveTypeCommandHandler : IRequestHandler<UpdateLeaveTypeCommand, Unit>
{
    private readonly ILeaveTypeRepository _repository;
    private readonly IMapper _mapper;
    
    public UpdateLeaveTypeCommandHandler(ILeaveTypeRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<Unit> Handle(UpdateLeaveTypeCommand request, CancellationToken cancellationToken)
    {
        var leaveType = await _repository.Get(request.LeaveTypeDto.Id);
        _mapper.Map(request.LeaveTypeDto, leaveType);
        await _repository.Update(leaveType);
        return Unit.Value;
    }
}