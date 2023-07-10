using Entities.Dtos;
using Entities.Models;
using Repositories.Contracts;
using Services.Contracts;

namespace Services
{
    public class IsEmriRotaService : IIsEmriRotaService
    {
        private readonly IRepositoryManager _manager;

        public IsEmriRotaService(IRepositoryManager manager)
        {
            _manager = manager;
        }

        public IQueryable<UYIsEmriRotasi> GetIsEmriRotaById(int isEmriRotaId) => _manager.IsEmriRota.IsEmriRotasiById(isEmriRotaId);

        public void updateIsEmriRotasi(UYIsEmriRotasiUpdateDto isEmriRota) => _manager.IsEmriRota.UpdateIsEmriRotasi(isEmriRota);
        
    }
}
