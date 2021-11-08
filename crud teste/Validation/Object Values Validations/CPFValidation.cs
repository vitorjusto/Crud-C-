using crud_teste.Model;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud_teste.Validation
{
    public class CPFValidation : AbstractValidator<MyCPF>
    {
        public CPFValidation()
        {
            RuleFor(x => x.ToString()).NotEmpty().Matches(@"[0-9]{3}[,][0-9]{3}[,][0-9]{3}\-[0-9]{2}").WithMessage("CPF Inválido");


        }
    }
}
