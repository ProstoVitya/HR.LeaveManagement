using HR.LeaveManagement.Application.Dto.Common;
using HR.LeaveManagement.Application.Dto.LeaveType;

namespace HR.LeaveManagement.Application.Dto.LeaveRequest;

public class LeaveRequestListDto : BaseDto
{
    public LeaveTypeDto LeaveType { get; set; }
    public DateTime DateRequested { get; set; }
    public bool? Approved { get; set; }
}