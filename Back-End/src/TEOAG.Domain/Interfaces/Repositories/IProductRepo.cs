using System.Threading.Tasks;
using TEOAG.Domain.Entities;

namespace TEOAG.Domain.Interfaces.Repositories
{
    public interface IProductRepo
    {
         Task<Product[]> PegaTodasAsync();
         Task<Product> PegaPorIdAsync();
         Task<Product> PegaPorTituloAsync();
    }
}