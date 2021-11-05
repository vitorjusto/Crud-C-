using crud_teste.Model;
using FluentValidation;
using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud_teste.Validation
{
    class ContatoValidation : AbstractValidator<Contato>
    {
        public ContatoValidation()
        {
            RuleFor(x => x.Email).Matches(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$").WithMessage("Email inválido");

            RuleFor(x => x.Telefone).Matches(@"[0-9]{4} - [0-9]{4}").WithMessage("Telefone Invalido");

            RuleFor(x => x.DDI).Matches(@"\+[0-9]{2}").WithMessage("DDI inválida");

            RuleFor(x => x.Celular).Matches(@"\([0-9]{2}\) 9[0-9]{3} - [0-9]{4}").WithMessage("Celular inválida");



        }
        

    }
}
