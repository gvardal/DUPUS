namespace Entities.Models
{
    public class UYIsEmriRotasi
    {
        public int IsEmriRotaID { get; set; }
        public int IsEmriID { get; set; }
        public UYIsEmri? IsEmri { get; set; }
        public string OperasyonuKodu { get; set; } = string.Empty;
        public int? OncekiIsEmriRotaID { get; set; }
        public int? Sira { get; set; }
        public int? KonumID { get; set; }
        public int? IslemTuruID { get; set; }
        public int? CalisanID { get; set; }
        public decimal? CalisanSayisi { get; set; }
        public int? RotaDurumu { get; set; }
        public int? HazirlikDurumu { get; set; }
        public string? Aciklama { get; set; } = string.Empty;
        public decimal? PlanlananGirdi { get; set; }
        public DateTime? PlanlananBaslamaTarihi { get; set; }
        public DateTime? PlanlananBitisTarihi { get; set; }
        public DateTime? EnErkenBaslamaTarihi { get; set; }

        //Sabitlenmis
        //PlanlananTamamlanmaZamani
        //HazirlamaSuresi
        //IslemSuresi
        //StandartSure
        //Mesafe
        //OnSeriKontrolAdedi
        //LotBuyuklugu
        //OrtalamaCevrimSuresi
        //SonCevrimZamani
        //GerceklesenCikti
        //Fire
        //TamamlanmaOrani
        //VardiyaKodu
        //SonVardiyaMiktari
        //GozSayisi
        public DateTime? GerceklesenBaslamaTarihi { get; set; }
        public DateTime? GerceklesenBitisTarihi { get; set; }
        //
        //
        //GerceklesenTamamlanmaZamani
        //IsAkisSoruGrubuID
        //IsAkisSoruGrubuIDAra
        //IsAkisSoruGrubuIDSon
        //KaliteKontrolRaporu
        //Tamamlandi
        //SaatlikUcreti
        //PlanlananMaliyet
        //GerceklesenMaliyet
        //EkipmanID
        //IsEmriOnayi
        //Onaylayan
        //MakinaID
        //YevmiyeKaydiID
        //TopluKayit
        //ManuelIsciZamanKarti
        //EnvanterID
        //UretimVerisiID
        //PaletNo
        //KutuNo
        //OtomatikDurus
        //FasonUrunID
        //KullanilanMiktar
        //SecenID
        //Secili

        public int? EkleyenCalisanID { get; set; }
        public DateTime EklemeTarihi { get; set; }
        public int? DuzenleyenCalisanID { get; set; }
        public DateTime DuzenlemeTarihi { get; set; }
        public int? SonErisenCalisanID { get; set; }
        public DateTime SonErisimTarihi { get; set; }
    }
}
