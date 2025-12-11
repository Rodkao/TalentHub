using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using TalentHub.Application.Interfaces; 
using TalentHub.Domain; 
using TalentHub.Infrastructure.Persistence; 


namespace TalentHub.Infrastructure.Repositories
{
    // Implementa las órdenes de IJobOfferRepository
    public class JobOfferRepository : IJobOfferRepository
    {
        private readonly TalentHubDbContext _context;

        // Context 
        public JobOfferRepository(TalentHubDbContext context)
        {
            _context = context;
        }

        // Orden: "dame todas las ofertas"
        public async Task<List<JobOffer>> GetAllAsync()
        {
            // se traen todos los registros de la tabla JobOffers
            return await _context.JobOffers.ToListAsync();
        }

        // Orden: "dame una orden por ID"
        public async Task<JobOffer?> GetByIdAsync(Guid id)
        {
            return await _context.JobOffers.FindAsync(id);
        }

        // Orden: "guarda esta oferta"
        public async Task AddAsync(JobOffer jobOffer)
        {
            _context.JobOffers.Add(jobOffer);
            await _context.SaveChangesAsync();
        }
    }
}
