using CRUD_teste.Model;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            RuleFor(x => x.Numero).GreaterThan(0).WithMessage("Digite um numero válido");
        }



    }
}
