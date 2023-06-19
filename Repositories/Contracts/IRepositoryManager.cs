namespace Repositories.Contracts
{
    public interface IRepositoryManager
    {
        IIsEmriRotaRepository IsEmriRota { get; }
        IIsEmriRepository IsEmri { get; }
        IUYKonumTuruRepository UYKonumTuru { get; }
        IUYKonumRepository UYKonum { get; }
        IUYUrunlerRepository UYUrunler { get; }
        void Save();
    }
}
