using System.Threading.Tasks;
using TEOAG.Domain.Entities;

namespace TEOAG.Domain.Interfaces.Repositories
{
    public interface IProductRepo : IGeneralRepo
    {
         Task<Product[]> PegaTodasAsync();
         Task<Product> PegaPorIdAsync(int id);
         Task<Product> PegaPorTituloAsync(string productName);
    }
}