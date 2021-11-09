using crud_teste.Model;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud_teste.Validation
{
    class DadosBancariosValidation : AbstractValidator<DadosBancarios>
    {
        
        public DadosBancariosValidation()
        {
            RuleFor(x => x.Banco).NotEmpty().WithMessage("Banco inválido");
            RuleFor(x => x.Agencia).Length(3).Matches(@"[0-9]{3}").WithMessage("Agencia inválida");
            RuleFor(x => x.Conta).Length(5).Matches(@"[0-9]{5}").WithMessage("Conta inválida");
            RuleFor(x => x.Digito).Length(1).Matches(@"[0-9]{1}").WithMessage("Digito do Banco inválida");
        }


    }
}
