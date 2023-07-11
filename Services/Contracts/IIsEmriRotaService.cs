using Entities.Models;

namespace Services.Contracts
{
    public interface IIsEmriRotaService
    {
        string updateIsEmriRotasi(UYIsEmriRotasi isEmriRota);
        IQueryable<UYIsEmriRotasi> GetIsEmriRotaById(int isEmriRotaId, bool trackChanges);
    }
}
