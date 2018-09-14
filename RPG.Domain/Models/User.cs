using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RPG.Domain.Models
{
    public class User
    {

        [Required(ErrorMessage = "O {0} é obrigatório!")]
        [StringLength(12, ErrorMessage = "O {0} deve ter entre 4 e 12 caracteres!", MinimumLength = 4)]
        [Display(Name = "Nick")]
        public string Nickname { get; set; }

        [Required(ErrorMessage = "O {0} é obrigatório!")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "A {0} é obrigatória!")]
        [Display(Name = "Senha")]
        [MinLength(4, ErrorMessage = "A {0} deve ter no mínimo 4 caracteres!")]
        [MaxLength(20, ErrorMessage = "A {0} deve ter no máximo 20 caracteres!")]
        public string Password { get; set; }

    }
}
