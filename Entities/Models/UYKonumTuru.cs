using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("UYKonumTuru", Schema = "UretimYonetimi")]
    public class UYKonumTuru
    {
        public byte KonumTuruID { get; set; }
        public string? Ad { get; set; }
    }
}
