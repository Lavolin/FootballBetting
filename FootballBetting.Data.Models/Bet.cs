namespace FootballBetting.Data.Models
{
    using FootballBetting.Data.Models.Enums;
    using System.ComponentModel.DataAnnotations;

    using System;

    public class Bet
    {
        [Key]
        public int BetId { get; set; }
        public decimal Amount { get; set; }
        public Prediction Prediction { get; set; }

        public DateTime DateTime { get; set; }  //Required by default
        public int UserId { get; set; }
        public int GameId { get; set; }
    }
}
