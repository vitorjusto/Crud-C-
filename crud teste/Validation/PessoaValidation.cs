using CRUD_teste.Model;
using FluentValidation;

using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud_teste.Validation
{
    class PessoaValidation : AbstractValidator<Pessoa>
    {
        public PessoaValidation()
        {
            RuleFor(x => x.Nome).NotEmpty().WithMessage("Nome não pode ser vazio");


            RuleFor(x => x.Sexo).NotEmpty().WithMessage("Sexo não pode ser vazio");


            RuleFor(x => x.DataDeNascimento).NotEmpty().WithMessage("Data Não npode ser vazio");


            RuleFor(x => x.CPF).Matches(@"[0-9]{3}[,][0-9]{3}[,][0-9]{3}\-[0-9]{2}").WithMessage("CPF Inválido");


            RuleFor(x => x.endereco).SetValidator(new EnderecoValidation()).WithMessage("Endereços invalidos");


            RuleFor(x => x.contato).SetValidator(new ContatoValidation()).WithMessage("Digite pelo menos um campo de contato");

            
        }

    }
}
