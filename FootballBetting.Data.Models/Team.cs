namespace FootballBetting.Data.Models
{
    using FootballBetting.Data.Common;
    using System.ComponentModel.DataAnnotations;


    public class Team
    {
        [Key]
        public int TeamID { get; set; }

        [Required]
        [MaxLength(GlobalConstants.TeamNameMaxLength)]
        public string Name { get; set; }

        [MaxLength(GlobalConstants.TeamLogoURLMaxLength)]
        public string LogoUrl { get; set; }

        [Required]
        [MaxLength(GlobalConstants.TeamInitialsMaxLength)]
        public string Initials { get; set; }

        // required by default in EF 3.1.1
        public decimal Budget { get; set; }

        //TODO: Define relations
        public int PrimaryKitColorId { get; set; }
        public int SecondaryKitColorId { get; set; }
        public int TownId { get; set; }
    }
}
