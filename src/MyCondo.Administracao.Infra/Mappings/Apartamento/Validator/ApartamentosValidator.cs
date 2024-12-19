using FluentValidation;
using MyCondo.Administracao.Domain.Entities.Apartamento;

namespace MyCondo.Administracao.Infra.Mappings.Apartamento.Validator;

public class ApartamentosValidator : AbstractValidator<Apartamentos>
{
    public ApartamentosValidator()
    {
        RuleFor(p => p.Numero)
            .NotEmpty()
            .MaximumLength(150)
            .WithMessage("Número do Apartamento é obrigatório");
    }
}
