using System.ComponentModel.DataAnnotations;

namespace SimpleWebApi.ViewModels.Account
{
    public class RegisterExternalBindingModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}