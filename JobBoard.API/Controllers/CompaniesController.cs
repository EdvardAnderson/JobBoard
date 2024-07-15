using AutoMapper;
using JobBoard.API.Models;
using JobBoard.API.Services;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace JobBoard.API.Controllers;

[ApiController]
[Route("api/companies")]
public class CompanyController : ControllerBase
{
    private readonly ICompanyRepository _companyRepository;
    private readonly IMapper _mapper;

    public CompanyController(ICompanyRepository companyRepository, IMapper mapper)
    {
        _companyRepository =
            companyRepository ?? throw new ArgumentNullException(nameof(companyRepository));
        _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
    }

    [HttpPost]
    public async Task<ActionResult<CompanyDto>> CreateCompany(CompanyForCreationDto company)
    {
        throw new NotImplementedException();
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
