using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Stark.WebUI.Areas.Admin.Models
{
    public class ChangePasswordViewModel
    {
        [Required]
        [Display(Name = "Kullanıcı Adınız")]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Eski Şifreniz")]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name ="Yeni Şifreniz")]
        public string NewPassword { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare(nameof(NewPassword), ErrorMessage = "Şifreler aynı değil.")]
        [Display(Name = "Yeni Şifreniz Yeniden")]
        public string ConfirmNewPassword { get; set; }
    }
}
