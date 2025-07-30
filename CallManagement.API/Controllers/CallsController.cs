using CallManagement.Application.Usecases;
using CallManagement.Application.DTOs;
using CallManagement.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CallManagement.API.Controllers;

[ApiController]
[Route("api/calls")]
public class CallsController : ControllerBase
{
    private readonly CreateCallUseCase _createCall;
    private readonly GetCallsByDateUseCase _getCalls;
    private readonly GetCallStatsUseCase _getStats;

    public CallsController(
        CreateCallUseCase createCall,
        GetCallsByDateUseCase getCalls,
        GetCallStatsUseCase getStats)
    {
        _createCall = createCall;
        _getCalls = getCalls;
        _getStats = getStats;
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CallDto callDto)
    {
        await _createCall.ExecuteAsync(
            callDto.PhoneNumber,
            callDto.CallTime,
            callDto.Status,
            callDto.AudioFilePath);
        return Ok(new { message = "Call created successfully" });
    }

    [HttpGet]
    public async Task<IActionResult> GetByDate([FromQuery] DateTime date)
    {
        var result = await _getCalls.ExecuteAsync(date);
        return Ok(result);
    }

    [HttpGet("stats")]
    public async Task<IActionResult> GetStats()
    {
        var result = await _getStats.ExecuteAsync();
        return Ok(result);
    }
}
