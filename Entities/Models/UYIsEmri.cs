using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("UYIsEmri", Schema = "UretimYonetimi")]
    public class UYIsEmri
    {
        public long IsEmriID { get; set; }
        public int? FirmaID { get; set; }
        public int? MusteriKodu { get; set; }
        public Int64? UretimPlaniID { get; set; }
        public int? KesimIsEmriID { get; set; }
        public decimal? KesimSuresi { get; set; }
        public decimal? KesilenMalzemeAgirligi { get; set; }
        public int? UstIsEmriID { get; set; }
        public string? IsEmriKodu { get; set; } 
        public int UrunID { get; set; }
        public int? IsEmriTuruID { get; set; }
        public string? UretimTuru { get; set; } 
        public int? SiparisNo { get; set; }
        public Byte? IsEmriDurumID { get; set; }
        public string? Oncelik { get; set; }
        public decimal? UretimMiktari { get; set; }
        public decimal? StokRezervasyonMiktari { get; set; }
        public decimal? RezervasyonMiktari { get; set; }
        public decimal? StokMiktari { get; set; }
        public decimal? FireMiktari { get; set; }
        public DateTime? BaslangicTarihi { get; set; }
        public DateTime? GerceklesenBaslangicTarihi { get; set; }
        public DateTime? BitisTarihi { get; set; }
        public DateTime? GerceklesenBitisTarihi { get; set; }
        public DateTime? TerminTarihi { get; set; }
        public decimal? GerceklesenSure { get; set; }
        public string? Aciklama { get; set; } 
        public string? DurumNotu { get; set; } 
        public string? UretimHatti { get; set; } 
        public bool? IsEmriOnayi { get; set; }
        public int? Onaylayan { get; set; }
        public bool? Secili { get; set; }
        public bool SenkronizeEdildi { get; set; }
        public DateTime? SenkronizasyonTarihi { get; set; }
        public string? SenkronizasyonAciklamasi { get; set; } 
        public string? SenkronizasyonReferansi { get; set; } 
        public int? EkleyenCalisanID { get; set; }
        public DateTime? EklemeTarihi { get; set; }
        public int? DuzenleyenCalisanID { get; set; }
        public DateTime? DuzenlemeTarihi { get; set; }
        public int? SonErisenCalisanID { get; set; }
        public DateTime? SonErisimTarihi { get; set; }
    }
}
