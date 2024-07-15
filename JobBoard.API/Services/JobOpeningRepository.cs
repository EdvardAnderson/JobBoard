using JobBoard.API.Entities;
using JobBoard.API.Services;

namespace JobBoard.API;

public class JobOpeningRepository : IJobOpeningRepository
{
    public void AddJobOpening(Guid companyId, JobOpening jobOpening)
    {
        throw new NotImplementedException();
    }

    public void DeleteJobOpening(JobOpening jobOpening)
    {
        throw new NotImplementedException();
    }

    public Task<JobOpening> GetJobOpening(Guid companyId, Guid jobopeningId)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<JobOpening>> GetJobOpenings(Guid companyId)
    {
        throw new NotImplementedException();
    }

    public void UpdateJobOpening(JobOpening jobOpening)
    {
        throw new NotImplementedException();
    }
}
