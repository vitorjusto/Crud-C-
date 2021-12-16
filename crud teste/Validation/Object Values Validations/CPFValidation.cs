using crud_teste.Model;
using FluentValidation;
using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace crud_teste.Validation
{
    public class CPFValidation : AbstractValidator<MyCPF>
    {
        public CPFValidation()
        {
            RuleFor(x => x).Must(ValidarCPF).WithMessage("CPF Inválido");
        }

        public bool ValidarCPF(MyCPF CPF)
        {
            if(new Regex(@"[0-9]{3}[,][0-9]{3}[,][0-9]{3}[-][0-9]{2}").IsMatch(CPF.RetornarFormatado()))
            {
                var DigitosValidadores = "";
                var soma = 0;

                    var index = 1;
                    foreach (var digito in CPF.ToString().Substring(0, 9))
                    {
                        soma += Convert.ToInt32(digito.ToString()) * index;
                        index++;
                    }

                    DigitosValidadores += (soma % 11).ToString().Last();

                soma = 0;

                index = 1;
                foreach (var digito in CPF.ToString().Substring(1, 8))
                {
                    soma += Convert.ToInt32(digito.ToString()) * index;
                    index++;
                }
                soma += Convert.ToInt32(DigitosValidadores.ToString()) * index;

                DigitosValidadores += (soma % 11).ToString().Last();

                return CPF.ToString().Substring(9, 2) == DigitosValidadores;


            }

            return false;
        }
    }
}
