namespace FootballBetting.Data.Models
{
    using FootballBetting.Data.Common;
    using System.ComponentModel.DataAnnotations;
    public class Position
    {
        [Key]
        public int PositionId { get; set; }

        [Required]
        [MaxLength(GlobalConstants.PositionNameMaxLength)]
        public string Name { get; set; }
    }
}
