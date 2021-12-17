using CRUD_teste.Model;
using FluentValidation;
using System.Text.RegularExpressions;

namespace crud_teste.Validation
{
    public class EnderecoValidation : AbstractValidator<Endereco>
    {
        public EnderecoValidation()
        {
            RuleFor(x => x.Cep).SetValidator(new CEPValidation()).WithMessage("CEP inválida");


            RuleFor(x => x.Logradouro).NotEmpty().Matches(@"[a-zA-ZÀ-úÀ-ÿ0-9 ]+").WithMessage("Logradouro invalido");

            RuleFor(x => x.Cidade).NotEmpty().NotNull().Matches(@"[a-zA-ZÀ-úÀ-ÿ ]+").WithMessage("Cidade inválida");

            RuleFor(x => x.UF).NotEmpty().WithMessage("Campo UF é obrigatório");

            RuleFor(x => x.Bairro).NotEmpty().Matches(@"[a-zA-ZÀ-úÀ-ÿ]+").WithMessage("Campo bairro é obrigatório");

            RuleFor(x => x.Numero).Must(ValidarNumero).WithMessage("Digite um numero válido");
        }

        public bool ValidarNumero(string numero)
        {
            try
            {
                return new Regex("[0-9]+").IsMatch(numero) || new Regex("[0-9]+[a-z]").IsMatch(numero) || new Regex("[sS]/[nN]").IsMatch(numero);
            }catch
            {
                return false;
            }
        }
    }
}
