using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace graduation.Model
{
    [Table("MRI_Results")]
    public class MRI_Result
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ResultId { get; set; }

        [Required]
        public bool Result { get; set; }

        [DataType(DataType.DateTime)]
        [Required]
        public DateTime ResultDate { get; set; }


        [Required]
        [DataType(DataType.Url)]
        public string BrainMriUrl { get; set; } = "https://www.123.com";

        //nav props

        [Required]
        public int UserId { get; set; }

        [ForeignKey("UserId"),JsonIgnore]
        public virtual User? User { get; set; }
    }
}
