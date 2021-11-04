using crud_teste.Model;
using CRUD_teste.Model;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud_teste.Validation
{
    class ClienteValidation : AbstractValidator<Cliente>
    {
        public ClienteValidation()
        {
            RuleFor(x => x).SetValidator(new PessoaValidation());
        }
    }
}
