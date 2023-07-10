using AutoMapper;
using Repositories.Contracts;
using Services.Contracts;

namespace Services
{
    public class ServiceManager : IServiceManager
    {
        private readonly IMapper _mapper;
        private readonly Lazy<IIsEmriService> _isEmriServices;
        private readonly Lazy<IIsEmriRotaService> _isEmriRotaServices;
        private readonly Lazy<IKonumTuruService> _konumTuruServices;
        private readonly Lazy<IKonumService> _konumServices;
        private readonly Lazy<IUrunlerService> _urunlerServices;

        public ServiceManager(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _mapper = mapper;
            _isEmriServices = new Lazy<IIsEmriService>(() => new IsEmriService(repositoryManager));
            _isEmriRotaServices = new Lazy<IIsEmriRotaService>(() => new IsEmriRotaService(repositoryManager,_mapper));
            _konumTuruServices = new Lazy<IKonumTuruService>(() => new KonumTuruService(repositoryManager));
            _konumServices = new Lazy<IKonumService>(() => new KonumService(repositoryManager,mapper));
            _urunlerServices = new Lazy<IUrunlerService>(() => new UrunlerService(repositoryManager));
        }

        public IIsEmriService IsEmriService => _isEmriServices.Value;
        public IIsEmriRotaService IsEmriRotaService => _isEmriRotaServices.Value;
        public IKonumTuruService KonumTuruService => _konumTuruServices.Value;
        public IKonumService KonumService => _konumServices.Value;
        public IUrunlerService UrunlerService => _urunlerServices.Value;
    }
}
