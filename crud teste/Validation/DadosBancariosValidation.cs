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

        } 
    }
}
