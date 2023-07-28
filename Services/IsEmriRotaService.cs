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

        public IQueryable<UYIsEmriRotasi> GetIsEmriRotaById(int isEmriRotaId, bool trackChanges) => _manager.IsEmriRota.IsEmriRotasiById(isEmriRotaId, trackChanges);

        public string updateIsEmriRotasi(UYIsEmriRotasi isEmriRota)
        {
            _manager.IsEmriRota.UpdateIsEmriRotasi(isEmriRota);
            _manager.Save();
            return $"{isEmriRota.IsEmriRotaID} Updated Successfully";
        }

    }
}
