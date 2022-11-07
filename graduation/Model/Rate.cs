using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace graduation.Model
{
    public class Rate
    {
        [Key]
        public int UserId { get; set; }

        public User User { get; set; } = new User();

        public string? Comment { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
