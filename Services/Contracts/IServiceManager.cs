namespace Services.Contracts
{
    public interface IServiceManager
    {
        IIsEmriService IsEmriService { get; }
        IKonumTuruService KonumTuruService { get; }
        IKonumService KonumService { get; }
    }
}
