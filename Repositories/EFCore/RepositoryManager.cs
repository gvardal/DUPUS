using Repositories.Contracts;

namespace Repositories.EFCore
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _context;
        private readonly Lazy<IIsEmriRotaRepository> _IsEmriRotaRepository;
        private readonly Lazy<IIsEmriRepository> _IsEmriRepository;
        private readonly Lazy<IUYKonumTuruRepository> _KonumTuruRepository;
        private readonly Lazy<IUYKonumRepository> _KonumRepository;
        private readonly Lazy<IUYUrunlerRepository> _UrunlerRepository;


        public RepositoryManager(RepositoryContext context)
        {
            _context = context;
            _IsEmriRotaRepository = new Lazy<IIsEmriRotaRepository>(() => new IsEmriRotaRepository(_context));
            _IsEmriRepository = new Lazy<IIsEmriRepository>(() => new IsEmriRepository(_context));
            _KonumTuruRepository = new Lazy<IUYKonumTuruRepository>(() => new UYKonumTuruRepository(_context));
            _KonumRepository = new Lazy<IUYKonumRepository>(() => new UYKonumRepository(_context));
            _UrunlerRepository = new Lazy<IUYUrunlerRepository>(() => new UYUrunlerRepository(_context));
            
        }

        public IIsEmriRotaRepository IsEmriRota => _IsEmriRotaRepository.Value;
        public IIsEmriRepository IsEmri => _IsEmriRepository.Value;
        public IUYKonumTuruRepository UYKonumTuru => _KonumTuruRepository.Value;
        public IUYKonumRepository UYKonum => _KonumRepository.Value;
        public IUYUrunlerRepository UYUrunler => _UrunlerRepository.Value;

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
