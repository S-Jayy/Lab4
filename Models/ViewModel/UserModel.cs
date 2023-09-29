using System.ComponentModel.DataAnnotations;

namespace MyWebApplication.Models.ViewModel
{
    public class UserModel
    {
        [Key]
        public int UserID { get; set; }
        [Required(ErrorMessage = "*")]
        [Display(Name = "Enter Username")]
        public string LoginName { get; set; }
        [Required(ErrorMessage = "*")]
        [Display(Name = "Password")]
        public string Password { get; set; }
        [Required(ErrorMessage = "*")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "*")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "*")]
        [Display(Name = "ID Number")] 
        public string IDNumber { get; set; } 

        [Required(ErrorMessage = "*")]
        [Display(Name = "Email Address")] 
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string EmailAddress { get; set; } 
        public string Gender { get; set; }
        [Required(ErrorMessage = "*")]
        [Display(Name = "Created By")]
        public int CreatedBy { get; set; }

        [Display(Name = "Image")]
        [DataType(DataType.Upload)]
        public IFormFile Image { get; set; }

    }
    public class UsersModel
    {
        public List<UserModel> Users { get; set; }
    }

    public class Add
    {
        public List<UserModel> Adds { get; set; }
    }
}
