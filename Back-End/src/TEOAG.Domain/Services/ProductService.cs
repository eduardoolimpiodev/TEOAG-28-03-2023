using System.Threading.Tasks;
using TEOAG.Domain.Entities;
using TEOAG.Domain.Interfaces.Repositories;
using TEOAG.Domain.Interfaces.Services;

namespace TEOAG.Domain.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepo _productRepo;
        private readonly IGeneralRepo _generalRepo;
        public ProductService(IProductRepo productRepo, IGeneralRepo generalRepo)
        {
            _productRepo = productRepo;
            _generalRepo = generalRepo;
        }

        public Task<Product> AdicionarProduto(Product model)
        {
            throw new System.NotImplementedException();
        }

        public Task<Product> AtualizarProduto(Product model)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> ConcluirProduto(Product model)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> DeletarProduct(int productId)
        {
            throw new System.NotImplementedException();
        }

        public Task<Product> PegarProdutoPorIdAsync(int productId)
        {
            throw new System.NotImplementedException();
        }

        public Task<Product[]> PegarTodosProdutosAsync()
        {
            throw new System.NotImplementedException();
        }
    }
}