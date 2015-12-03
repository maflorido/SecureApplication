using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SecureApp.Web.Models.Home
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="{0} is Required.")]
        [DisplayName("User name")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "{0} is Required.")]
        [DataType(DataType.Password)]
        [DisplayName("Password")]
        public string Password { get; set; }

        [DisplayName("Remember me?")]
        public bool RememberMe { get; set; }
    }
}