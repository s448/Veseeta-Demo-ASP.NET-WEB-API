using Microsoft.EntityFrameworkCore;

namespace graduation.Model
{
    [Keyless]
    public class WorkingPeriod
    {
        public string? From { get; set; } 
        public string? To { set; get; } 
    }
}
