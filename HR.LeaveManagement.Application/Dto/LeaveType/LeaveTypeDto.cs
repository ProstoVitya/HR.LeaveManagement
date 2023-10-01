using HR.LeaveManagement.Application.Dto.Common;

namespace HR.LeaveManagement.Application.Dto.LeaveType;

public class LeaveTypeDto : BaseDto
{
    public string Name { get; set; }
    public int DefaultDays { get; set; }
}