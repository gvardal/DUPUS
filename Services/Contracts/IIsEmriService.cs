using Entities.Models;

namespace Services.Contracts
{
    public interface IIsEmriService
    {
        IEnumerable<UYIsEmri> GetAllIsEmri();
        UYIsEmri? GetIsEmriById(int id);
    }
}
