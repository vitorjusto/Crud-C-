using CRUD_teste.Model;
using FluentValidation;

using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crud_teste.Validation
{
    class PessoaValidation : AbstractValidator<Pessoa>
    {
        public PessoaValidation()
        {
            RuleFor(x => x.Nome).NotEmpty().WithMessage("Nome não pode ser vazio");


            RuleFor(x => x.Sexo).NotEmpty().WithMessage("Sexo não pode ser vazio");


            RuleFor(x => x.DataDeNascimento).NotEmpty().WithMessage("Data Não pode ser vazio");

            RuleFor(x => x.CPF).SetValidator(new CPFValidation()).WithMessage("CPF inválida");


            RuleFor(x => x.endereco).SetValidator(new EnderecoValidation()).WithMessage("Endereços invalidos");

            RuleFor(x => x.contato).SetValidator(new ContatoValidation()).WithMessage("Digite pelo menos um campo de contato");

        }

    }
}
