using CallManagement.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallManagement.Application.Usecases;

public class GetCallStatsUseCase
{
    private readonly ICallRepository _repository;

    public GetCallStatsUseCase(ICallRepository repository)
    {
        _repository = repository;
    }

    public async Task<object> ExecuteAsync()
    {
        var total = await _repository.CountTotalAsync();
        var success = await _repository.CountByStatusAsync("success");
        var fail = await _repository.CountByStatusAsync("fail");

        return new
        {
            Total = total,
            SuccessRate = total == 0 ? 0 : (success * 100.0) / total,
            FailRate = total == 0 ? 0 : (fail * 100.0) / total
        };
    }
}

