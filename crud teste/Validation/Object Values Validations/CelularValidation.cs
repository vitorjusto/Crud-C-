using crud_teste.Model.Object_Values;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud_teste.Validation.Object_Values_Validations
{
    public class CelularValidation : AbstractValidator<MyCelular>
    {
        public CelularValidation()
        {

            RuleFor(x => x.RetornarDDIComFormatacao()).NotEmpty().Matches(@"\+[0-9]{2}").WithMessage("DDI inválida");

            RuleFor(x => x.RetornarCelularComFormatacao()).NotEmpty().Matches(@"\([0-9]{2}\) 9[0-9]{3} - [0-9]{4}").WithMessage("Celular inválida");
        }
    }
}
