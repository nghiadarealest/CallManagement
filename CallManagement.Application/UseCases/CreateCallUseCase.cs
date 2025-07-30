using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CallManagement.Domain.Entities;
using CallManagement.Domain.Interfaces;

namespace CallManagement.Application.Usecases;

public class CreateCallUseCase
{
    private readonly ICallRepository _repository;

    public CreateCallUseCase(ICallRepository repository)
    {
        _repository = repository;
    }

    public async Task ExecuteAsync(string phoneNumber, DateTime callTime, string status, string audioFilePath)
    {
        var call = new Call
        {
            Id = Guid.NewGuid(),
            PhoneNumber = phoneNumber,
            CallTime = callTime,
            Status = status,
            AudioFilePath = audioFilePath
        };

        await _repository.AddAsync(call);
    }
}

