using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("UYUretimPlani", Schema = "UretimYonetimi")]
    public class UYUretimPlani
    {
        public long UretimPlaniID { get; set; }
        public byte? FirmaID { get; set; }
        public int? IsAlaniID { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public string? UretimPlaniKodu { get; set; }
        public int? RevizyonNo { get; set; }
        public int? UretimPlaniTuruID { get; set; }
        public int? MIYSAHesapID { get; set; }
        public int? ProjeID { get; set; }
        public int? ProjeAdimiID { get; set; }
        public int? SiparisID { get; set; }
        public int? UrunID { get; set; }

        [Column(TypeName = "decimal(8, 2)")]
        public decimal UretimMiktari { get; set; }

        [Column(TypeName = "decimal(8, 2)")]
        public decimal StokMiktari { get; set; }

        [Column(TypeName = "decimal(8, 2)")]
        public decimal FireMiktari { get; set; }

        public int? LotBuyuklugu { get; set; }
        public string? UretimTuru { get; set; }
        public string? Durum { get; set; }
        public int? DurumID { get; set; }
        public string? Oncelik { get; set; }
        public DateTime PlanlananBaslamaTarihi { get; set; }
        public DateTime PlanlananBitimTarihi { get; set; }
        public DateTime GerceklesenBaslamaTarihi { get; set; }
        public DateTime GerceklesenBitimTarihi { get; set; }
        public DateTime GerceklesenSure { get; set; }
        public string? Aciklama { get; set; }
        public string? AksesuarNotu { get; set; }
        public string? SiparisNotu { get; set; }
        public string? PlanlamaNotu { get; set; }
        public string? ProjeNotu { get; set; }
        public string? Sonuc { get; set; }
        public string? UretimHatti { get; set; }

        [Column(TypeName = "decimal(8, 2)")]
        public decimal UretimKatsayisi { get; set; }

        public string? EklentiDosyaAdi { get; set; }
        public Int64? SiparisDetayiID { get; set; }
        public Int64? KesimIsEmriNo { get; set; }
        public int? KonumID { get; set; }
        public bool? Planlandi { get; set; }
        public int? PlanlayanID { get; set; }

        [Column(TypeName = "decimal(7, 5)")]
        public decimal KullanilabilirFireOrani { get; set; }

        [Column(TypeName = "decimal(7, 5)")]
        public decimal HurdaOrani { get; set; }
        public int IslemTuruID { get; set; }

        [Column(TypeName = "decimal(16, 2)")]
        public decimal IslemSuresi { get; set; }
        public string? CAMDosyaYolu { get; set; }
        public bool? UretimPlaniOnayi { get; set; }
        public int? Onaylayan { get; set; }
        public DateTime OnayTarihi { get; set; }
        public bool? YevmiyeKaydi { get; set; }
        public DateTime YevmiyeKaydiTarihi { get; set; }
        public int? YevmiyeKaydiYapanID { get; set; }
        public Int64? YevmiyeDefteriID { get; set; }
        public bool SenkronizeEdildi { get; set; }
        public DateTime SenkronizasyonTarihi { get; set; }
        public string? SenkronizasyonAciklamasi { get; set; }
        public string? SenkronizasyonReferansi { get; set; }
        public DateTime EklemeTarihi { get; set; }
        public int? EkleyenCalisanID { get; set; }
        public int? DuzenleyenCalisanID { get; set; }
        public DateTime? DuzenlemeTarihi { get; set; }
        public int? SonErisenCalisanID { get; set; }
        public DateTime? SonErisimTarihi { get; set; }
    }
}
