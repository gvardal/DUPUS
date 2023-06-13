using Repositories.Contracts;

namespace Repositories.EFCore
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _context;
        private readonly Lazy<IIsEmriRotaRepository> _IsEmriRotaRepository;
        private readonly Lazy<IIsEmriRepository> _IsEmriRepository;

        public RepositoryManager(RepositoryContext context)
        {
            _context = context;
            _IsEmriRotaRepository = new Lazy<IIsEmriRotaRepository>(() => new IsEmriRotaRepository(_context));
            _IsEmriRepository = new Lazy<IIsEmriRepository>(() => new IsEmriRepository(_context));
        }

        public IIsEmriRotaRepository IsEmriRota => _IsEmriRotaRepository.Value;
        public IIsEmriRepository IsEmri => _IsEmriRepository.Value;

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
