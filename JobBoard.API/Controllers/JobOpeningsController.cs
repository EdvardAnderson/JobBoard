﻿using JobBoard.API.Entities;
using JobBoard.API.Models;
using JobBoard.API.Services;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace JobBoard.API.Controllers;

[ApiController]
[Route("api/companies/{companyId}/jobopenings")]
public class JobOpeniningsController : ControllerBase
{
    private readonly IJobOpeningRepository _jobOpeningsRepository;

    public JobOpeniningsController(IJobOpeningRepository jobOpeningsRepository)
    {
        _jobOpeningsRepository =
            jobOpeningsRepository ?? throw new ArgumentNullException(nameof(jobOpeningsRepository));
    }

    [HttpPost]
    public async Task<ActionResult<JobOpeningDto>> AddJobOpening(
        Guid companyId,
        JobOpeningForCreationDto jobOpening
    )
    {
        throw new NotImplementedException();
    }

    [HttpGet("{jobOpeningId}", Name = "GetJobOpening")]
    public async Task<ActionResult<JobOpeningDto>> GetJobOpening(Guid companyId, Guid jobOpeningId)
    {
        throw new NotImplementedException();
    }

    [HttpGet(Name = "GetJobOpenings")]
    public async Task<ActionResult<IEnumerable<JobOpeningDto>>> GetJobOpenings(Guid companyId)
    {
        throw new NotImplementedException();
    }

    [HttpPut("{jobOpeningId}")]
    public async Task<IActionResult> UpdateJobOpening(
        Guid companyId,
        Guid jobOpeningId,
        JobOpeningForUpdateDto jobOpening
    )
    {
        throw new NotImplementedException();
    }

    [HttpPatch("{jobOpeningId}")]
    public async Task<IActionResult> PartiallyUpdateJobOpening(
        Guid companyId,
        Guid jobOpeningId,
        JsonPatchDocument<JobOpeningForUpdateDto> patchDocument
    )
    {
        throw new NotImplementedException();
    }

    [HttpDelete("{jobOpeningId}")]
    public async Task<IActionResult> DeleteJobOpening(Guid jobOpeningId)
    {
        throw new NotImplementedException();
    }

    [HttpOptions]
    public IActionResult GetJobOpeningsOptions()
    {
        //Response.Headers.Add("Allow", "GET") todo add verbs!
        return Ok();
    }
}
