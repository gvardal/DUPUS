using Repositories.Contracts;
using Services.Contracts;

namespace Services
{
    public class ServiceManager : IServiceManager
    {
        private readonly Lazy<IIsEmriService> _isEmriServices;
        private readonly Lazy<IKonumTuruService> _konumTuruServices;
        private readonly Lazy<IKonumService> _konumServices;

        public ServiceManager(IRepositoryManager repositoryManager)
        {
            _isEmriServices = new Lazy<IIsEmriService>(() => new IsEmriService(repositoryManager));
            _konumTuruServices = new Lazy<IKonumTuruService>(() => new KonumTuruService(repositoryManager));
            _konumServices = new Lazy<IKonumService>(() => new KonumService(repositoryManager));
        }

        public IIsEmriService IsEmriService => _isEmriServices.Value;

        public IKonumTuruService KonumTuruService => _konumTuruServices.Value;

        public IKonumService KonumService => _konumServices.Value;
    }
}
