using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallManagement.Domain.Entities;

public class Call
{
    public Guid Id { get; set; }  // Mã cuộc gọi
    public string PhoneNumber { get; set; } = string.Empty;
    public DateTime CallTime { get; set; }
    public string Status { get; set; } = string.Empty; // success, fail, etc.
    public string AudioFilePath { get; set; } = string.Empty;
}

