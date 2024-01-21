namespace EYouthUnisco.Domain
{
    public class Session
    {
        public Guid SessionId { get; set; }

        public Guid UserId { get; set; }

        public string Token { get; set; } = null!;

        public DateTime ExpirationDate { get; set; }

        public virtual User User { get; set; } = null!;
    }
}