
namespace FootballBetting.Data.Models
{
    using FootballBetting.Data.Common;
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Game
    {

        [Key]
        public int GameId { get; set; }
        public int HomeTeamId { get; set; }
        public int AwayTeamId { get; set; }
        public byte HomeTeamGoals { get; set; }
        public byte AwayTeamGoals { get; set; }
        public DateTime DateTime { get; set; }
        public double HomeTeamBetRate { get; set; }
        public double AwayTeamBetRate { get; set; }
        public double DrawBetRate { get; set; }

        [MaxLength(GlobalConstants.GameResultMaxLength)] // __ : __
        public string Result { get; set; }
    }
}
