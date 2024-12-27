using FluentValidation;
using MyCondo.Administracao.Domain.Entities.VagaGaragem;

namespace MyCondo.Administracao.Infra.Mappings.VagaGaragem.Validator;

public class VagasGaragemValidator : AbstractValidator<VagasGaragem>
{
    public VagasGaragemValidator()
    {
        RuleFor(p => p.Nome)
            .NotEmpty()
            .MaximumLength(50)
            .WithMessage("Número do Apartamento é obrigatório");
    }
}
