using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCRM.Dto.AuthDtos
{
    public class LoginDto
    {
        [Required(ErrorMessage ="Kullanıcı Adı veyae-posta adresi girmnek zorunludur")]
        [Display(Name ="Kullanıcı Adı veya E-Posta")]
        public string UserNameOrEmail { get; set; }

        [Required(ErrorMessage =("Şifre Zorunludur"))]
        [Display(Name = "Şifre")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Beni Hatırla")]
        public bool RememberMe { get; set; }
    }
}
