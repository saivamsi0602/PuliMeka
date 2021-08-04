using System.ComponentModel.DataAnnotations;

namespace PuliMeka.Shared
{
    public class Player
    {
        [EmailAddress(ErrorMessage ="Email Address is not in the correct format")]
        [Required(ErrorMessage ="Email Address field is required")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Password is required")]
        public string Password { get; set; }
        [Required(ErrorMessage ="UserName is required")]
        public string UserName { get; set; }
    }
}
