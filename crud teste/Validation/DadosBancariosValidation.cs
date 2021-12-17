using crud_teste.Model;
using FluentValidation;

namespace crud_teste.Validation
{
    class DadosBancariosValidation : AbstractValidator<DadosBancarios>
    {

        public DadosBancariosValidation()
        {
            RuleFor(x => x.Banco).NotEmpty().WithMessage("Banco inválido");

            RuleFor(x => x.Agencia).GreaterThan(0).WithMessage("Agencia não pode ser zero");

            RuleFor(x => x.Agencia.ToString()).Length(3).WithMessage("Agencia inválida (certifique os zeros a esquerda)");

            RuleFor(x => x.Conta).GreaterThan(0).WithMessage("Conta não pode ser zero");

            RuleFor(x => x.Conta.ToString()).Length(5).WithMessage("Conta inválida (certifique os zeros a esquerda)");

            RuleFor(x => x.Digito.ToString()).Length(1).WithMessage("Digito da conta inválida");

        } 
    }
}
