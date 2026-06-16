using FluentValidation;
using FarmaciaInteligenteAPI.src.DTOs;

namespace FarmaciaInteligenteAPI.src.Validators;

public class MedicamentoValidator : AbstractValidator<MedicamentoResponseDTO>
{
    public MedicamentoValidator()
    {
        RuleFor(x => x.Nome).NotEmpty().WithMessage("O nome é obrigatório.");
        RuleFor(x => x.Preco).GreaterThan(0).WithMessage("O preço deve ser maior que zero.");
    }
}