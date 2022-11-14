using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace graduation.Model
{
    [Table("Users")]
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? UserId { get; set; }

        [Required]
        [StringLength(50)]
        public string UserName { get; set; } = "";

        [Required]
        [StringLength(50)]
        [DataType(DataType.EmailAddress)] 
        public string UserEmail { get; set; } = "";

        [Required,MinLength(10)]
        public string UserPhone { get; set; } = string.Empty;

        [DataType(DataType.Password),Required,MinLength(6)]
        public string UserPassword { get; set; }

        //nav props
        [AllowNull]
        public virtual List<MRI_Result>? MRI_Results { get; set; }
        [AllowNull]
        public virtual List<ClinicReservation>? ClinicReservations { get; set; }
    }
}
