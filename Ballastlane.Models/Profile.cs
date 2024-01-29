namespace Ballastlane.Models
{
    public class Profile
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string Alias { get; set; }
        public DateOnly Birthday { get; set; }
    }
}
