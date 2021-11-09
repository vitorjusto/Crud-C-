using crud_teste.Model;
using CRUD_teste.Model;
using FluentValidation;

namespace crud_teste.Validation
{
    public class CEPValidation : AbstractValidator<MyCEP>
    {
        public CEPValidation()
        {
            RuleFor(x => x.RetornarFormatado()).Matches(@"[0-9]{5}-[0-9]{3}").WithMessage("Cep inválido");

            
        }


    }
}
