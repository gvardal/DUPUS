using AutoMapper;
using Entities.Dtos;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.Contracts;
using Services.Contracts;

namespace Services
{
    public class IsEmriRotaService : IIsEmriRotaService
    {
        private readonly IRepositoryManager _manager;
        private readonly IMapper _mapper;

        public IsEmriRotaService(IRepositoryManager manager, IMapper mapper)
        {
            _manager = manager;
            _mapper = mapper;
        }

        public IQueryable<UYIsEmriRotasi> GetIsEmriRotaById(int isEmriRotaId) => _manager.IsEmriRota.IsEmriRotasiById(isEmriRotaId);

        public void updateIsEmriRotasi(UYIsEmriRotasi isEmriRota)
        {
            _manager.IsEmriRota.UpdateIsEmriRotasi(isEmriRota);
            _manager.Save();
        }

    }
}
