namespace LogisticsApp.Domain.Entities
{
    public class ApplicationUser
    {
        public string? Name { get; set; }
        public string? RefreshToken { get; set; }
        public DateTime RefreshTokenExpiryTime { get; set; }
    }
}
