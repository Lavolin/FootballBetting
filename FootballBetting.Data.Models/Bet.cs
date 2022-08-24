namespace FootballBetting.Data.Models
{
    using FootballBetting.Data.Models.Enums;
    using System.ComponentModel.DataAnnotations;

    using System;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Bet
    {
        [Key]
        public int BetId { get; set; }
        public decimal Amount { get; set; }
        public Prediction Prediction { get; set; }

        public DateTime DateTime { get; set; }  //Required by default


        [ForeignKey(nameof(User))]
        public int UserId { get; set; }
        public virtual User User { get; set; }


        [ForeignKey(nameof(Game))]
        public int GameId { get; set; }
        public virtual Game Game { get; set; }
    }
}
