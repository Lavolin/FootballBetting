namespace FootballBetting.Data.Models
{
    using FootballBetting.Data.Common;
    using System.ComponentModel.DataAnnotations;

    public class Player
    {
        [Key]
        public int PlayerId { get; set; }

        [Required]
        [MaxLength(GlobalConstants.PlayerNameMaxLength)]
        public string Name { get; set; }


        public byte SquadNumber { get; set; }

        public int TeamId { get; set; }
        public int PositionId { get; set; }
        public bool IsInjured { get; set; }
    }
}
