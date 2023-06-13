namespace Repositories.Contracts
{
    public interface IRepositoryManager
    {
        IIsEmriRotaRepository IsEmriRota { get; }
        IIsEmriRepository IsEmri { get; }
        void Save();
    }
}
