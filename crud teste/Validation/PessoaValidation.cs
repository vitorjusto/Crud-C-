using crud_teste.Model;
using CRUD_teste.Model;
using FluentValidation;
using System.Linq;

namespace crud_teste.Validation
{
    public class PessoaValidation : AbstractValidator<Pessoa>
    {
        public PessoaValidation()
        {
            RuleFor(x => x.Nome).NotEmpty().WithMessage("Nome não pode ser vazio");


            RuleFor(x => x.Sexo).NotEmpty().WithMessage("Sexo não pode ser vazio");


            RuleFor(x => x.DataDeNascimento).NotEmpty().WithMessage("Data Não pode ser vazio");

            RuleFor(x => x.CPF).SetValidator(new CPFValidation()).WithMessage("CPF inválida");


            RuleFor(x => x.endereco).SetValidator(new EnderecoValidation()).WithMessage("Endereços invalidos");


            RuleFor(x => x.contato).Must(ContatoValido).WithMessage("Preencha pelo menos um campo de contato");

        }

        private bool ContatoValido(Contato contato)
        {
            ContatoValidation validar = new ContatoValidation();
            var validares = validar.Validate(contato);

            return validares.Errors.Count() < 3;

        }

    }
}
