using crud_teste.Model;
using FluentValidation;

namespace crud_teste.Validation
{
    public class CarrinhoValidation : AbstractValidator<Pedido_Produto>
    {
        public CarrinhoValidation()
        {

            RuleFor(x => x.produto.IdProduto).GreaterThan(0).WithMessage("Escolha um produto primeiro!");
            
            RuleFor(x => x.Desconto.GetAsDouble()).GreaterThanOrEqualTo(0).WithMessage("Desconto não deve ser menor que zero");

            RuleFor(x => x.quantidade).GreaterThan(0).WithMessage("Quantidade tem que ser maior que zero");

            RuleFor(x => x.quantidadeRestante).GreaterThanOrEqualTo(0).WithMessage("Não pode ter mais quantidade do que estoque");

            RuleFor(x => x.PrecoLiquido.GetAsDouble()).GreaterThan(0).WithMessage("Preco liquido não pode ser negativo");

            RuleFor(x => x.PrecoBruto.GetAsDouble()).GreaterThanOrEqualTo(0).WithMessage("O preco bruto é maior que zero");

            RuleFor(x => x.precoDeVenda.GetAsDouble()).GreaterThanOrEqualTo(0).WithMessage("O preço unitário não pode ser negativo");

        }
    }
}
