using crud_teste.Model;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud_teste.Validation
{
    public class CarrinhoValidation : AbstractValidator<Carrinho>
    {
        public CarrinhoValidation()
        {

            RuleFor(x => x.idProduto).GreaterThan(0).WithMessage("Escolha um produto primeiro!");
            
            RuleFor(x => x.Desconto).GreaterThanOrEqualTo(0).WithMessage("Desconto não deve ser menor que zero");

            RuleFor(x => x.quantidade).GreaterThan(0).WithMessage("Quantidade tem que ser maior que zero");

            RuleFor(x => x.quantidadeRestante).GreaterThanOrEqualTo(0).WithMessage("Não pode ter mais quantidade do que estoque");

            RuleFor(x => x.PrecoLiquido).GreaterThan(0).WithMessage("Preco liquido não pode ser negativo");

            RuleFor(x => x.PrecoBruto).GreaterThanOrEqualTo(0).WithMessage("O preco bruto é maior que zero");

            RuleFor(x => x.precoDeVenda).GreaterThanOrEqualTo(0).WithMessage("O preço unitário não pode ser negativo");

        }
    }
}
