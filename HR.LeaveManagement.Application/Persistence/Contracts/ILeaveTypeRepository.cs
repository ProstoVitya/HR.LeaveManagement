using HR.LeaveManagement.Application.Dto;
using HR.LeaveManagement.Domain;

namespace HR.LeaveManagement.Application.Persistence.Contracts;

public interface ILeaveTypeRepository : IGenericRepository<LeaveType>
{
    Task<LeaveTypeDto> GetLeaveTypeDetails(int id);
    Task<List<LeaveType>> GetLeaveTypes();
}