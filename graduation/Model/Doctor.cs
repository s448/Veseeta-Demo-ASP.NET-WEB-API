using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace graduation.Model
{
    [Table("Doctors")]
    public class Doctor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? DoctorId { get; set; }

        [Required]
        [StringLength(50)]
        public string DoctorName { get; set; } = "";

        [Required]
        [StringLength(50)]
        [DataType(DataType.EmailAddress)]
        public string DoctorEmail { get; set; } = "";

        [Required, MaxLength(11), MinLength(11), DataType(DataType.PhoneNumber)]
        public int UserPhone { get; set; }

        [DataType(DataType.Password), Required]
        public int DoctorPassword { get; set; }

        [AllowNull]
        public List<Rate>? DoctorRate { set; get; }

        [AllowNull]
        public string Speciality { set; get; }

       


        //nav props
        public List<Clinic>? Clinics { get; set; } = new List<Clinic>();
        public List<Consultation>? Consultations { get; set; } = new List<Consultation>();
    }
}
