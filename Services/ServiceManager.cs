using AutoMapper;
using Repositories.Contracts;
using Services.Contracts;

namespace Services
{
    public class ServiceManager : IServiceManager
    {
        private readonly IMapper _mapper;
        private readonly Lazy<IIsEmriService> _isEmriServices;
        private readonly Lazy<IKonumTuruService> _konumTuruServices;
        private readonly Lazy<IKonumService> _konumServices;

        public ServiceManager(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _mapper = mapper;
            _isEmriServices = new Lazy<IIsEmriService>(() => new IsEmriService(repositoryManager));
            _konumTuruServices = new Lazy<IKonumTuruService>(() => new KonumTuruService(repositoryManager));
            _konumServices = new Lazy<IKonumService>(() => new KonumService(repositoryManager,mapper));
        }

        public IIsEmriService IsEmriService => _isEmriServices.Value;

        public IKonumTuruService KonumTuruService => _konumTuruServices.Value;

        public IKonumService KonumService => _konumServices.Value;
    }
}
