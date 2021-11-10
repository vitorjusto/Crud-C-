using crud_teste.Model;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud_teste.Validation
{
    class ProdutoValidation : AbstractValidator<Produto>
    {
        public ProdutoValidation()
        {
            RuleFor(x => x.NomeDoProduto).NotEmpty().WithMessage("Nome não pode ser vazio");
            
            RuleFor(x => x.CodigoDeBarras).NotEmpty().WithMessage("Codigo De Barras Não Pode Ser Vazio");
            RuleFor(x => x.CodigoDeBarras.Length).GreaterThan(13).WithMessage("O Codigo de barras deve ser maior que 13").LessThan(16).WithMessage("O Codigo de barras deve ser menor que 16");

            RuleFor(x => x.PrecoDeVenda).GreaterThan(0).WithMessage("O preço da venda deve ser maior que zero");
            RuleFor(x => x.PrecoDeCusto).GreaterThan(0).WithMessage("O preco de custo deve ser maior que zero");
            RuleFor(x => x.DescontoAVista).GreaterThanOrEqualTo(0).WithMessage("O preco de Desconto deve ser maior ou igual a zero");
            RuleFor(x => x.Estoque).GreaterThanOrEqualTo(0).WithMessage("O Estoque não pode ser vazio");

            RuleFor(x => x.Fabricante).NotEmpty().WithMessage("Fabricante não deve ser vazio");



        }

    }
}
