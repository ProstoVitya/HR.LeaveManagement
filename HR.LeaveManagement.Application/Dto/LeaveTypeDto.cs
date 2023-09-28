using HR.LeaveManagement.Application.Dto.Common;

namespace HR.LeaveManagement.Application.Dto;

public class LeaveTypeDto : BaseDto
{
    public string Name { get; set; }
    public int DefaultDays { get; set; }
}