using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CallManagement.Domain.Entities;
using CallManagement.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CallManagement.Infrastructure.Persistence;

public class SqliteCallRepository : ICallRepository
{
    private readonly CallDbContext _context;

    public SqliteCallRepository(CallDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(Call call)
    {
        _context.Calls.Add(call);
        await _context.SaveChangesAsync();
    }

    public async Task<List<Call>> GetCallsByDateAsync(DateTime date)
    {
        return await _context.Calls
            .Where(c => c.CallTime.Date == date.Date)
            .ToListAsync();
    }

    public async Task<int> CountTotalAsync()
    {
        return await _context.Calls.CountAsync();
    }

    public async Task<int> CountByStatusAsync(string status)
    {
        return await _context.Calls.CountAsync(c => c.Status.ToLower() == status.ToLower());
    }
}

