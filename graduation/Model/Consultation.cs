using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace graduation.Model
{
    public class Consultation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? ConsId { get; set; }

        [Required]
        [DataType(DataType.Url)]
        public string BrainMriUrl { get; set; } = "https://www.123.com";

        [DataType(DataType.DateTime)]
        [Required]
        public DateTime DateOfUpload { get; set; }

        [Required]
        public string? Status { get; set; }

        //نتيجة الفحص
        [Required]
        public bool Result { get; set; }

        [AllowNull, MaxLength(120)]
        public string? UserComment { get; set; }

        [AllowNull, MaxLength(500)]
        public string? DoctorComment { get; set; }

        //nav prop

        [Required]
        public int? DoctorId { get; set; }
        [Required, ForeignKey("DoctorId")]
        public Doctor Doctor { get; set; }

        [Required]
        public int? UserId { get; set; }
        [Required, ForeignKey("UserId")]
        public User User { get; set; } = new User();
    }
}
