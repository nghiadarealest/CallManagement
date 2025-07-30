using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CallManagement.Domain.Entities;

namespace CallManagement.Domain.Interfaces;

public interface ICallRepository
{
    Task AddAsync(Call call);
    Task<List<Call>> GetCallsByDateAsync(DateTime date);
    Task<int> CountTotalAsync();
    Task<int> CountByStatusAsync(string status);
}

