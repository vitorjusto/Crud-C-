using crud_teste.Model;
using CRUD_teste.Model;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud_teste.Validation
{
    public class VendaValidation : AbstractValidator<Venda>
    {

        public VendaValidation()
        {
            RuleFor(x => x.cliente.idCliente).GreaterThan(0).WithMessage("Selecione um cliente");

            RuleFor(x => x.colaborador.idColaborador).GreaterThan(0).WithMessage("Selecione um colaborador");

            RuleFor(x => x.TipoDeVenda).NotEmpty().WithMessage("Selecione um tipo de venda");


            

            RuleFor(x => x.QuantidadeUnitario).GreaterThan(0).WithMessage("Adicione um produto");

            RuleFor(x => x.TotalLiquido.GetAsDouble()).GreaterThanOrEqualTo(0).WithMessage("Total Liquido não pode ser menor que zero");
            
            RuleFor(x => x.TotalDeDesconto.GetAsDouble()).GreaterThanOrEqualTo(0).WithMessage("Total de desconto não pode ser negativo");
            
            RuleFor(x => x.TotalBruto.GetAsDouble()).GreaterThanOrEqualTo(0).WithMessage("Total bruto não pode ser negativo");
        }

        public VendaValidation(decimal valorLimite, Venda venda)
        {
            RuleFor(x => x.cliente.idCliente).GreaterThan(0).WithMessage("Selecione um cliente");

            RuleFor(x => x.colaborador.idColaborador).GreaterThan(0).WithMessage("Selecione um colaborador");

            RuleFor(x => x.QuantidadeUnitario).GreaterThan(0).WithMessage("Adicione um produto");

            RuleFor(x => x.TipoDeVenda).NotEmpty().WithMessage("Selecione um tipo de venda");


            if ((venda.TipoDeVenda) == "A vista")
            {
                RuleFor(x => x.DescontoAVista.GetAsDouble()).GreaterThan(0).WithMessage("O desconto a vista não pode ser nulo");
            }
            else if (venda.TipoDeVenda == "A Prazo")
            {
                RuleFor(x => x.MesesAPrazo).GreaterThan(0).WithMessage("A quantidade de mezes não pode ser nulo");
                RuleFor(x => x.TotalLiquido.GetAsDouble()).LessThan((float)valorLimite).WithMessage("O Total Liquido é maior que o valor limite");
            }


            RuleFor(x => x.TotalLiquido.GetAsDouble()).GreaterThanOrEqualTo(0).WithMessage("Total Liquido não pode ser menor que zero");

            RuleFor(x => x.TotalDeDesconto.GetAsDouble()).GreaterThanOrEqualTo(0).WithMessage("Total de desconto não pode ser negativo");

            RuleFor(x => x.TotalBruto.GetAsDouble()).GreaterThanOrEqualTo(0).WithMessage("Total bruto não pode ser negativo");
        }
    }
}
