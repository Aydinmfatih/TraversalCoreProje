using System.ComponentModel.DataAnnotations;

namespace TraversalCoreProje.Models
{
    public class UserRegisterViewModel
    {

        [Required(ErrorMessage ="Lütfen Adınızı Giriniz")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Lütfen Soyadınızı Giriniz")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Lütfen Kullanıcı Adını Giriniz")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Lütfen Mailinizi Giriniz")]
        public string Mail { get; set; }
        [Required(ErrorMessage = "Lütfen Şifreyi Giriniz")]
        public string Password { get; set; }
        [Compare("Password",ErrorMessage ="Şifreler uyumlu değil")]
        public string ConfirmPassword { get; set; }
    }
}
