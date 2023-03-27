using System.Threading.Tasks;
using TEOAG.Domain.Entities;

namespace TEOAG.Domain.Interfaces.Services
{
    public interface IProductService
    {
        Task<Product> AdicionarProduto(Product model);

        Task<Product> AtualizarProduto(Product model);

        Task<bool> DeletarProduct(int productId);

        Task<bool> ConcluirProduto(Product model);

        Task<Product[]> PegarTodosProdutosAsync();

        Task<Product> PegarProdutoPorIdAsync(int productId);
    }
}