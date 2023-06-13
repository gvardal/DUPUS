using Repositories.Contracts;
using Services.Contracts;

namespace Services
{
    public class ServiceManager : IServiceManager
    {
        private readonly Lazy<IIsEmriService> _isEmriServices;

        public ServiceManager(IRepositoryManager repositoryManager)
        {
            _isEmriServices = new Lazy<IIsEmriService>(() => new IsEmriService(repositoryManager));
        }

        public IIsEmriService IsEmriService => _isEmriServices.Value;
    }
}
