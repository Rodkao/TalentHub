using TalentHub.Domain;

namespace TalentHub.Tests;

public class JobOfferTests
{
    [Fact] 
    public void Creacion_DebeFallar_SiSalarioEsNegativo()
    {
        // Preparar datos
        string titulo = "Senior Dev";
        string desc = "Descripcion valida";
        decimal salarioInvalido = -100;

        // Act/Assert 
        var exception = Assert.Throws<ArgumentException>(() =>
        {
            new JobOffer(titulo, desc, salarioInvalido);
        });

        Assert.Equal("El salario no puede ser negativo. (Parameter 'salary')", exception.Message);
    }

    [Fact]
    public void Creacion_DebeFuncionar_SiDatosSonCorrectos()
    {
        // Arrange
        string titulo = "Senior Dev";
        string desc = "Descripcion valida";
        decimal salarioValido = 3000;

        // Act
        var oferta = new JobOffer(titulo, desc, salarioValido);

        // Assert 
        Assert.NotNull(oferta);
        Assert.Equal(salarioValido, oferta.Salary);
    }
}