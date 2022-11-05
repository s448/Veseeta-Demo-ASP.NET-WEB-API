namespace graduation.Model
{
    public class Rate
    {
        public int UserId { get; set; }

        public User User { get; set; } = new User();

        public String? Comment { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
