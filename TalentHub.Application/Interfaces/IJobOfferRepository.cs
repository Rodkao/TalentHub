using System;
using System.Collections.Generic;
using System.Text;
using TalentHub.Domain;

namespace TalentHub.Application.Interfaces
{
    public interface IJobOfferRepository
    {
        Task<List<JobOffer>> GetAllAsync();
        Task<JobOffer?> GetByIdAsync(Guid id);
        Task AddAsync(JobOffer jobOffer);
    }
}


