using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallManagement.Application.DTOs;

public class CallDto
{
    public string PhoneNumber { get; set; } = string.Empty;
    public DateTime CallTime { get; set; }
    public string Status { get; set; } = string.Empty;
    public string AudioFilePath { get; set; } = string.Empty;
}
