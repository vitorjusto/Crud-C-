using crud_teste.Model;
using FluentValidation;

namespace crud_teste.Validation
{
    public class ProdutoValidation : AbstractValidator<Produto>
    {
        public ProdutoValidation()
        {
            RuleFor(x => x.NomeDoProduto).NotEmpty().WithMessage("Nome não pode ser vazio");
            
            RuleFor(x => x.CodigoDeBarras).NotEmpty().WithMessage("Codigo De Barras Não Pode Ser Vazio")
                .Length(13, 16).WithMessage("Codigo De Barras deve ter entre 13 e 16 caracteres");
           

            RuleFor(x => x.PrecoDeVenda.GetAsDouble()).GreaterThan(0).WithMessage("O preço da venda deve ser maior que zero");
            RuleFor(x => x.PrecoDeCusto.GetAsDouble()).GreaterThan(0).WithMessage("O preco de custo deve ser maior que zero");
            RuleFor(x => x.Estoque).GreaterThanOrEqualTo(0).WithMessage("O Estoque não pode ser vazio");

            RuleFor(x => x.Fabricante).NotEmpty().WithMessage("Fabricante não deve ser vazio");



        }

    }
}
