using JobBoard.API.Entities;

namespace JobBoard.API.Services;

public interface ICompanyRepository
{
    Task<IEnumerable<Company>> GetCompanies();

    Task<Company> GetCompany(Guid companyId);

    void UpdateCompany(Company company);

    void DeleteCompany(Company company);
}
