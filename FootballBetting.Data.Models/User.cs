namespace FootballBetting.Data.Models
{
    using FootballBetting.Data.Common;
    using System.ComponentModel.DataAnnotations;

    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        [MaxLength(GlobalConstants.UserUsernameMaxLength)]
        public string Username { get; set; }

        [Required]
        [MaxLength(GlobalConstants.UserPasswordMaxLength)]
        public string Password { get; set; }  // Hashed string

        [Required]
        [MaxLength(GlobalConstants.UserEmailMaxLength)]
        public string Email { get; set; }

        [Required]
        [MaxLength(GlobalConstants.UserNameMaxLength)]
        public string Name { get; set; }
        public decimal Balance { get; set; }
    }
}
