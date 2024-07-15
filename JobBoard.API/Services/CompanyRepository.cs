using JobBoard.API.Entities;
using JobBoard.API.Services;

namespace JobBoard.API;

public class CompanyRepository : ICompanyRepository
{
    public void DeleteCompany(Company company)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Company>> GetCompanies()
    {
        throw new NotImplementedException();
    }

    public Task<Company> GetCompany(Guid companyId)
    {
        throw new NotImplementedException();
    }

    public void UpdateCompany(Company company)
    {
        throw new NotImplementedException();
    }
}
