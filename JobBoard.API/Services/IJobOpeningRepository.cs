using JobBoard.API.Entities;

namespace JobBoard.API.Services;

public interface IJobOpeningRepository
{
    void AddJobOpening(Guid companyId, JobOpening jobOpening);
    void UpdateJobOpening(JobOpening jobOpening);
    void DeleteJobOpening(JobOpening jobOpening);

    Task<JobOpening> GetJobOpening(Guid companyId, Guid jobopeningId);
    Task<IEnumerable<JobOpening>> GetJobOpenings(Guid companyId);
}
