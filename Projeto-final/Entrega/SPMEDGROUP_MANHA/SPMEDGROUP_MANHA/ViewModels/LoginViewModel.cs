using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SPMEDGROUP_MANHA.ViewModels
{
    public class LoginViewModel
    {

        [Required(ErrorMessage = "Email necessario para Login")]
        [StringLength(255, MinimumLength = 5, ErrorMessage = "O e-mail deve ter entre 5 e 255 caractéres.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Senha necessaria para Login")]
        [StringLength(255, MinimumLength = 5, ErrorMessage = "A senha deve ter entre 5 e 255 caractéres.")]
        public string Senha { get; set; }
    }
}
