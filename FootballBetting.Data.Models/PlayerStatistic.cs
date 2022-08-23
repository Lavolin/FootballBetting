namespace FootballBetting.Data.Models
{

    // Mapping class
    public class PlayerStatistic
    {
        //TODO: Define composite PK in Fluent API
        public int GameId { get; set; }
        public int PlayerId { get; set; }
        public byte ScoredGoals { get; set; }
        public byte Assists { get; set; }
        public byte MinutesPlayed { get; set; }
    }
}
