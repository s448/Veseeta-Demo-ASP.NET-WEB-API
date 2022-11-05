using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace graduation.Model
{
    public class ClinicReservation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ResId { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required, ForeignKey("UserId")]
        public User User { get; set; } = new User();

        [Required]
        public int ClinicId { get; set; }

        [Required, ForeignKey("ClinicId")]
        public Clinic Clinic { get; set; } = new Clinic();

        [Required]
        public Dictionary<String, String>? FromTo { get; set; }

        [Required]
        public String PaymentMethod { get; set; } = "";

        [AllowNull,MaxLength(120)]
        public String? Note { get; set; }
    }
}
