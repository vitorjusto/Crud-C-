using crud_teste.Model;
using crud_teste.Validation.Object_Values_Validations;
using FluentValidation;
using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud_teste.Validation
{
    public class ContatoValidation : AbstractValidator<Contato>
    {
        public ContatoValidation()
        {
            
            RuleFor(x => x.Email).Matches(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$").WithMessage("Email inválido");

            RuleFor(x => x.Telefone).SetValidator(new TelefoneValidation());

            RuleFor(x => x.Celular).SetValidator(new CelularValidation());


        }
        

    }
}
