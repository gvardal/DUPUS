using Entities.Dtos;
using Entities.Models;

namespace Services.Contracts
{
    public interface IIsEmriRotaService
    {
        void updateIsEmriRotasi(UYIsEmriRotasiUpdateDto isEmriRota);

        IQueryable<UYIsEmriRotasi> GetIsEmriRotaById(int isEmriRotaId);
    }
}
