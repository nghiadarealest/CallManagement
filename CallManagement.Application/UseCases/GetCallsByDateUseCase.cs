using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CallManagement.Domain.Entities;
using CallManagement.Domain.Interfaces;

namespace CallManagement.Application.Usecases;

public class GetCallsByDateUseCase
{
    private readonly ICallRepository _repository;

    public GetCallsByDateUseCase(ICallRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<Call>> ExecuteAsync(DateTime date)
    {
        return await _repository.GetCallsByDateAsync(date);
    }
}

