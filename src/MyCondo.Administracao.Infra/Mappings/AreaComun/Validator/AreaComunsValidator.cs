using FluentValidation;
using MyCondo.Administracao.Domain.Entities.AreaComun;

namespace MyCondo.Administracao.Infra.Mappings.AreaComun.Validator;

public class AreaComunsValidator : AbstractValidator<AreaComuns>
{
    public AreaComunsValidator()
    {
        RuleFor(p => p.Nome)
            .NotEmpty()
            .MaximumLength(150)
            .WithMessage("Nome é obrigatório e não pode ser maior que 150 caracteres");
    }
}
