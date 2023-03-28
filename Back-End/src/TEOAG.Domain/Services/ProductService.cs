using System;
using System.Threading.Tasks;
using TEOAG.Domain.Entities;
using TEOAG.Domain.Interfaces.Repositories;
using TEOAG.Domain.Interfaces.Services;

namespace TEOAG.Domain.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepo _productRepo;
        public ProductService(IProductRepo productRepo)
        {
            _productRepo = productRepo;
        }

        public async Task<Product> AdicionarProduto(Product model)
        {
            if(await _productRepo.PegaPorTituloAsync(model.ProductName) != null)
                throw new Exception("Já existe um produto com esse nome");

            if(await _productRepo.PegaPorIdAsync(model.Id) == null)
            {
                _productRepo.Adicionar(model);
                if(await _productRepo.SalvarMudancasAsync())
                    return model;
            }     
            return null;

        }

        public async Task<Product> AtualizarProduto(Product model)
        {
            if(model.ManufacturingDate != null)
            throw new Exception("Não de pode alterar produto já concluído.");

             if(await _productRepo.PegaPorIdAsync(model.Id) == null)
            {
                _productRepo.Atualizar(model);
                if(await _productRepo.SalvarMudancasAsync())
                    return model;
            }     

            return null;
        }

        public async Task<bool> ConcluirProduto(Product model)
        {
            if(model != null)
            {
                model.Concluir();
                _productRepo.Atualizar<Product>(model);
                return await _productRepo.SalvarMudancasAsync();
            }
            return false;
        }

        public async Task<bool> DeletarProduct(int productId)
        {
            var product = await _productRepo.PegaPorIdAsync(productId);
            if(product == null) throw new Exception("Produto que tentou deletar não existe.");

            _productRepo.Deletar(product); 
            return await _productRepo.SalvarMudancasAsync();
            
        }

        public async Task<Product> PegarProdutoPorIdAsync(int productId)
        {
            try
            {
                 var product = await _productRepo.PegaPorIdAsync(productId);
                 if(product == null) return null;

                 return product;
            }
            catch (System.Exception ex)
            {
                
                throw new Exception(ex.Message);
            }
        }

        public async Task<Product[]> PegarTodosProdutosAsync()
        {
             try
            {
                 var products = await _productRepo.PegaTodasAsync();
                 if(products == null) return null;

                 return products;
            }
            catch (System.Exception ex)
            {
                
                throw new Exception(ex.Message);
            }
        }
    }
}