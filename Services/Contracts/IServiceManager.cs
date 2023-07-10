namespace Services.Contracts
{
    public interface IServiceManager
    {
        IIsEmriService IsEmriService { get; }
        IIsEmriRotaService IsEmriRotaService { get; }
        IKonumTuruService KonumTuruService { get; }
        IKonumService KonumService { get; }
        IUrunlerService UrunlerService { get; }
    }
}
