using JobBoard.API.Entities;
using JobBoard.API.Services;
using Microsoft.EntityFrameworkCore;

namespace JobBoard.API;

public class CompanyRepository : ICompanyRepository
{
    private JobBoardContext _context;

    public CompanyRepository(JobBoardContext context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
    }

    public void AddCompany(Company company)
    {
        if (company == null)
        {
            throw new ArgumentNullException(nameof(company));
        }

        _context.Companies.Add(company);
    }

    public async Task<IEnumerable<Company>> GetCompanies()
    {
        return await _context.Companies.OrderBy(_ => _.Name).ToListAsync();
    }

    public Task<Company> GetCompany(Guid companyId)
    {
        throw new NotImplementedException();
    }

    public void UpdateCompany(Company company)
    {
        throw new NotImplementedException();
    }

    public void DeleteCompany(Company company)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> SaveAsync()
    {
        return await _context.SaveChangesAsync() >= 1;
    }
}
