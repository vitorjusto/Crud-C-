using CRUD_teste.Model;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud_teste.Validation
{
    class ColaboradorValidator : AbstractValidator<Colaborador>
    {
        public ColaboradorValidator()
        {
            RuleFor(x => x).SetValidator(new PessoaValidation());

            RuleFor(x => x.Salario).GreaterThan(0).WithMessage("Salário deve ser Maior que zero");
        }

    }
}
