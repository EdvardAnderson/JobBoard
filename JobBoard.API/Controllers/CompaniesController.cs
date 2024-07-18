using AutoMapper;
using JobBoard.API.Models;
using JobBoard.API.Services;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace JobBoard.API.Controllers;

[ApiController]
[Route("api/companies")]
public class CompaniesController : ControllerBase
{
    private readonly ICompanyRepository _companyRepository;
    private readonly IMapper _mapper;

    public CompaniesController(ICompanyRepository companyRepository, IMapper mapper)
    {
        _companyRepository =
            companyRepository ?? throw new ArgumentNullException(nameof(companyRepository));
        _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
    }

    [HttpPost]
    public async Task<ActionResult<CompanyDto>> CreateCompany(CompanyForCreationDto company)
    {
        var companyEntity = _mapper.Map<Entities.Company>(company);
        _companyRepository.AddCompany(companyEntity);
        await _companyRepository.SaveAsync();

        var createdCompany = _mapper.Map<CompanyDto>(companyEntity);
        return CreatedAtRoute("GetCompany", new { companyId = companyEntity.Id }, createdCompany);
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<CompanyDto>>> GetCompanies()
    {
        throw new NotImplementedException();
    }

    [HttpGet("{companyId}", Name = "GetCompany")]
    public async Task<ActionResult<CompanyDto>> GetCompany(Guid companyId)
    {
        throw new NotImplementedException();
    }

    [HttpPut("{companyId}")]
    public async Task<IActionResult> UpdateCompany(Guid companyId, CompanyForUpdateDto company)
    {
        throw new NotImplementedException();
    }

    [HttpPatch]
    public async Task<IActionResult> PartiallyUpdateCompany(
        Guid companyId,
        JsonPatchDocument<CompanyForUpdateDto> patchDocument
    )
    {
        throw new NotImplementedException();
    }

    [HttpDelete("{companyId}")]
    public async Task<IActionResult> DeleteCompany(Guid companyId)
    {
        throw new NotImplementedException();
    }

    [HttpOptions]
    public IActionResult GetCompaniesOptions()
    {
        //Response.Headers.Add("Allow", "GET") todo add verbs!
        return Ok();
    }
}
