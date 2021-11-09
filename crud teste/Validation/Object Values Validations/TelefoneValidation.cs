using crud_teste.Model.Object_Values;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud_teste.Validation.Object_Values_Validations
{
    class TelefoneValidation : AbstractValidator<MyTelefone>
    {
        public TelefoneValidation()
        {
            RuleFor(x => x.ToString()).Length(8).WithMessage("Telefone Inválido");
        }
    }
    
}
