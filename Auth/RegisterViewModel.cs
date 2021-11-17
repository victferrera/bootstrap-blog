using System.ComponentModel.DataAnnotations;

namespace Auth
{
    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "Nome")]
        public string UserName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name ="Confirme a Senha")]
        [Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }
    }
}
