using System;
using System.Collections.Generic;
using System.Text;

namespace TalentHub.Domain
{
    public class JobOffer
    {
        public Guid Id { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public decimal Salary { get; private set; }
        public DateTime CreatedAt { get; private set; }

        // Constructor para EF
        private JobOffer() { }

        // Constructor con reglas de negocio
        public JobOffer(string title, string description, decimal salary)
        {
            if (string.IsNullOrWhiteSpace(title))
                throw new ArgumentNullException(nameof(title), "El título es obligatorio.");

            if (salary < 0)
                throw new ArgumentException("El salario no puede ser negativo.", nameof(salary));

            Id = Guid.NewGuid();
            Title = title;
            Description = description;
            Salary = salary;
            CreatedAt = DateTime.UtcNow;
        }
    }
}
