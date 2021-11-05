using crud_teste.Model;
using CRUD_teste.Model;
using FluentValidation;

namespace crud_teste.Validation
{
    class CEPValidation : AbstractValidator<MyCEP>
    {
        public CEPValidation()
        {
            RuleFor(x => x.ToString()).Matches(@"[0-9]{5}[-][0-9]{3}").WithMessage("Cep inválido");
        }
    }
}
