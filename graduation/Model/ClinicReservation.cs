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
        [NotMapped]
        public WorkingPeriod? FromTo { get; set; }

        [Required]
        public string PaymentMethod { get; set; } = "";

        [AllowNull,MaxLength(120)]
        public string? Note { get; set; }

        //nav props
        [Required]
        public int UserId { get; set; }
        [Required, ForeignKey("UserId")]
        public User User { get; set; }


        [Required]
        public int ClinicId { get; set; }
        [Required, ForeignKey("ClinicId")]
        public Clinic Clinic { get; set; }
    }
}
