﻿using CRUD_teste.Model;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud_teste.Validation
{
    class EnderecoValidation : AbstractValidator<Endereco>
    {
        public EnderecoValidation()
        {
            RuleFor(x => x.Cep).Matches(@"[0-9]{5}[-][0-9]{3}").WithMessage("Cep inválido");

            RuleFor(x => x.Logradouro).Matches(@"[a-zA-ZÀ-úÀ-ÿ0-9 ]+").WithMessage("Logradouro invalido");

            RuleFor(x => x.Cidade).Matches(@"[a-zA-ZÀ-úÀ-ÿ ]+").WithMessage("Cidade inválida");

            RuleFor(x => x.UF).NotEmpty().NotNull().WithMessage("Campo UF é obrigatório");

            RuleFor(x => x.Bairro).Matches(@"[a-zA-ZÀ-úÀ-ÿ]+").WithMessage("Campo bairro é obrigatório");

            RuleFor(x => x.Numero).GreaterThan(0).WithMessage("Digite um numero válido");
        }



    }
}
