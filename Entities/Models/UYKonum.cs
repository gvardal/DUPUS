using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("UYKonum", Schema = "UretimYonetimi")]
    public class UYKonum
    {
        public int KonumID { get; set; }
        public byte? FirmaID { get; set; }
        public string? KonumKodu { get; set; }
        public string? Ad { get; set; }
        public byte? KonumTuruID { get; set; }
        public int? MasrafMerkezi { get; set; }
        public decimal? MaliyetOrani { get; set; }
        public decimal? DogalgazMaliyeti { get; set; }
        public decimal? ElektrikMaliyeti { get; set; }
        public decimal? SuMaliyeti { get; set; }
        public decimal? Kapasite { get; set; }
        public decimal? VardiyaUzunlugu { get; set; }
        public byte? KisaMolalar { get; set; }
        public decimal? KisaMolaSuresi { get; set; }
        public byte? YemekMolasi { get; set; }
        public decimal? YemekMolaSuresi { get; set; }
        public decimal? IdealUretimHizi { get; set; }
        public byte? CalismaGrubu { get; set; }
        public byte? ParalelIslemSayisi { get; set; }
        public decimal? FireOrani { get; set; }
        public decimal? FazlaUretimToleransi { get; set; }
        public int? HammaddeTuketimKonumID { get; set; }
        public int? HammaddeTuketimBolmesiID { get; set; }
        public int? StokKonumu { get; set; }
        public int? YariMamulStokKonumuID { get; set; }
        public int? VarsayilanAraKontrolSoruGrubuID { get; set; }
        public int? UstKonumID { get; set; }
        public string? KonumKoduAdi { get; set; }
        public string? Aciklama { get; set; }
        public string? RaporAdi { get; set; }
        public bool? EksiyeDusebilir { get; set; }
        public string? IPAdres { get; set; }
        public string? SiraAraligi { get; set; }
        public string? RafAraligi { get; set; }
        public string? BolmeAraligi { get; set; }
        public int? XKoordinati { get; set; }
        public int? YKoordinati { get; set; }
        public bool? StokHareketleriniSirala { get; set; }
        public bool? Secili { get; set; }
        public bool? OtomatikEnvanterOlusturma { get; set; }
        public byte? DemirbasDurumu { get; set; }
        public bool? Aktif { get; set; }
        public int? EkleyenCalisanID { get; set; }
        public DateTime? EklemeTarihi { get; set; }
        public int? DuzenleyenCalisanID { get; set; }
        public DateTime? DuzenlemeTarihi { get; set; }
        public int? SonErisenCalisanID { get; set; }
        public DateTime? SonErisimTarihi { get; set; }
        public string? SenkronizasyonKodu { get; set; }
        public bool? SenkronizeEdildi { get; set; }
        public DateTime? SenkronizasyonTarihi { get; set; }
        public string? SenkronizasyonAciklamasi { get; set; }
    }
}
