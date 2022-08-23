namespace FootballBetting.Data.Models
{
    using FootballBetting.Data.Common;
    using System.ComponentModel.DataAnnotations;
    public class Country
    {
        [Key]
        public int CountryId { get; set; }

        [Required]
        [MaxLength(GlobalConstants.CountryNameMaxLength)]
        public string Name { get; set; }


    }
}
