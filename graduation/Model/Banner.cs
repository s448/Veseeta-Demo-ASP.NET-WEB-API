using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace graduation.Model
{
    [Table("Banners")]
    public class Banner
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int BannerId { get; set; }

        [Required]
        [DataType(DataType.Url)]
        public string BannerImgUrl { get; set; } = "https://www.123.com";

        [Required]
        [DataType(DataType.Url)]
        public string BannerRedirectionUrl { get; set; } = "https://www.123.com";
    }
}
