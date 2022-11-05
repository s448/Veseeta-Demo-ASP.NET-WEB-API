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
        public int DoctorId { get; set; }

        [ForeignKey("DoctorId")]
        [Required]
        public User Doctor { get; set; } = new User();

        [Required]
        [MaxLength(50)]
        public string ClinicName { get; set; } = "";

        [Required]
        [MaxLength(100)]
        public String ClinicAddress { get; set; } = "";

        [MaxLength(500)]
        public String Description { get; set; } = "";

        //weekly blackout days
        [AllowNull]
        public List<String>? OffDays { get; set; }

        //daily work time from .. to ..
        [AllowNull]
        public List<Dictionary<String, String>>? FromTo { get; set; }

        [AllowNull]
        public List<Rate>? ClinicRate { set; get; }
    }
}
