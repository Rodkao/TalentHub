using Microsoft.AspNetCore.Mvc;
using TalentHub.Application.Interfaces;
using TalentHub.Domain;

namespace TalentHub.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    // Usamos Primary Constructor: Inyectamos el Gerente (IJobOfferRepository)
    public class JobOffersController(IJobOfferRepository repository) : ControllerBase
    {
        // 1. Endpoint para obtener todas las ofertas
        [HttpGet]
        public async Task<ActionResult<List<JobOffer>>> Get()
        {
            var offers = await repository.GetAllAsync();
            return Ok(offers);
        }

        // 2. Endpoint para crear una oferta nueva
        [HttpPost]
        public async Task<ActionResult> Post(string title, string description, decimal salary)
        {
            try
            {
                // Usamos el constructor del Domain que tiene las validaciones
                var newOffer = new JobOffer(title, description, salary);

                await repository.AddAsync(newOffer);

                return CreatedAtAction(nameof(Get), new { id = newOffer.Id }, newOffer);
            }
            catch (ArgumentException ex)
            {
                // Si el salario es negativo, el Dominio lanza error
                return BadRequest(ex.Message);
            }
        }
    }
}

