using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace graduation.Model
{
    public class Clinic
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ClinicId { get; set; }

        [Required]
        [MaxLength(50)]
        public string ClinicName { get; set; } = "";

        [Required]
        [MaxLength(100)]
        public string ClinicAddress { get; set; } = "";

        [MaxLength(500)]
        public string Description { get; set; } = "";

        //weekly blackout days
        //[AllowNull]
        //public List<string> OffDays { get; set; } 

        //daily work time from .. to ..
        [AllowNull]
        [NotMapped]
        public List<WorkingPeriod>? FromTo { get; set; }

        [AllowNull]
        public List<Rate>? ClinicRate { set; get; }

        //nav props
        public List<ClinicReservation> ClinicReservations { get; set; }

        [Required]
        public int DoctorId { get; set; }
        [ForeignKey("DoctorId")]
        [Required]
        public Doctor Doctor { get; set; }

    }
}
