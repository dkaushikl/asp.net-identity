namespace Demo.API.Models
{
    using System.ComponentModel.DataAnnotations;

    public class ChangePasswordModel
    {
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "New Password Required")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Old Password Required")]
        public string OldPassword { get; set; }
    }
}