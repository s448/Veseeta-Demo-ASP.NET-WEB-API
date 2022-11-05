using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace graduation.Model
{
    [Table("Users")]
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }

        [Required]
        [StringLength(50)]
        public string UserName { get; set; } = "";

        [Required]
        [StringLength(50)]
        [DataType(DataType.EmailAddress)]
        public string UserEmail { get; set; } = "";

        [Required,MaxLength(11),MinLength(11),DataType(DataType.PhoneNumber)]
        public int UserPhone { get; set; }

        [DataType(DataType.Password),Required]
        public int UserPassword { get; set; }

        //normal user or doctor
        [Required]
        public String AccType { set; get; } = "User";

        //for users of type doctor only
        [AllowNull]
        public List<Rate> ? DoctorRate { set; get; }

        //for users of type doctor only
        [AllowNull]
        public String Speciality { set; get; }
    }
}
