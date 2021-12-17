using CRUD_teste.Model;
using FluentValidation;
namespace crud_teste.Validation
{
    class ClienteValidation : AbstractValidator<Cliente>
    {
        public ClienteValidation()
        {
            RuleFor(x => x).SetValidator(new PessoaValidation());

            RuleFor(x => x.LimiteDeCompra.GetAsDecimal()).GreaterThanOrEqualTo(0).WithMessage("Valor Acumulado não deve ser maior que o valor limite");

            RuleFor(x => x.LimiteRestante.GetAsDecimal()).GreaterThanOrEqualTo(0).WithMessage("Limite restante não pode ser menor que zero");
        }
    }
}
