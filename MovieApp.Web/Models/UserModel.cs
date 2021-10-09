using MovieApp.Web.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Web.Models
{
    public class UserModel
    {
        public int UserId { get; set; }

        [Required(ErrorMessage ="Kullanıcı ismi boş bırakılamaz.")]
        [StringLength(10, ErrorMessage ="En fazla 10 karakter olmalıdır.")]
        public string UserName { get; set; }

        [Required(ErrorMessage ="İsim alanı boş bırakılamaz.")]
        [StringLength(15, ErrorMessage ="En fazla 15 karakter olmalıdır.", MinimumLength = 3)]
        public string Name { get; set; }

        [Required(ErrorMessage ="E-mail adresi boş bırakılamaz.")]
        [EmailAddress]
        [EmailProviders]
        public string Email { get; set; }

        [Required(ErrorMessage ="Şifre alanı boş bırakılamaz.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "2. Şifre alanı boş bırakılamaz.")]
        [DataType(DataType.Password)]
        [Compare(nameof(Password))]
        public string RePassword { get; set; }
        [Url]
        public string Url { get; set; }
        //[Range(1900,2010,ErrorMessage ="Lütfen 1900-2010 arasında bir değer seçiniz.")]
        //public int BirthYear { get; set; }
        [BirthDate(ErrorMessage ="Doğum tarihiniz bugünden küçük olmalıdır.")]
        [DataType(DataType.Date)]
        [Display(Name = "Birth Date")]
        public DateTime BirthDate { get; set; }
    }
}
