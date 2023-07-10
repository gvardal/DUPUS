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

        public void updateIsEmriRotasi(UYIsEmriRotasi isEmriRota)
        {
            throw new NotImplementedException();
        }
    }
}
