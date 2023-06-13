using Entities.Models;
using Repositories.Contracts;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class IsEmriService : IIsEmriService
    {
        private readonly IRepositoryManager _manager;

        public IsEmriService(IRepositoryManager manager)
        {
            _manager = manager;
        }

        public IEnumerable<UYIsEmri> GetAllIsEmri() => _manager.IsEmri.GetAllIsEmriList().Take(5);

        public UYIsEmri? GetIsEmriById(int id) => _manager.IsEmri.IsEmriById(id).SingleOrDefault();
    }
}
