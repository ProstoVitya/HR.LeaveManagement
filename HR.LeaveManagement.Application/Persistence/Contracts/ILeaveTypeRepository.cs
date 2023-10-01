using HR.LeaveManagement.Application.Dto.LeaveType;
using HR.LeaveManagement.Domain;

namespace HR.LeaveManagement.Application.Persistence.Contracts;

public interface ILeaveTypeRepository : IGenericRepository<LeaveType>
{
    Task<LeaveTypeDto> GetLeaveTypeDetails(int id);
    Task<List<LeaveType>> GetLeaveTypes();
}