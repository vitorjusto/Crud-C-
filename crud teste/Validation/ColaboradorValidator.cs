using CRUD_teste.Model;
using FluentValidation;

namespace crud_teste.Validation
{
    public class ColaboradorValidator : AbstractValidator<Colaborador>
    {
        public ColaboradorValidator()
        {
            RuleFor(x => x).SetValidator(new PessoaValidation());

            RuleFor(x => x.Salario.GetAsDecimal()).GreaterThan(0).WithMessage("Salário deve ser Maior que zero");

            RuleFor(x => x.DadosBancarios).SetValidator(new DadosBancariosValidation()).WithMessage("Dados Bancarios Incorreto");
        }

    }
}
