using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RPG.Domain.Models
{
    public class OpponentClass
    {

        [Required(ErrorMessage = "O {0} é obrigatório!")]
        [Display(Name = "Nome da Classe")]
        public string ClassName { get; set; }

        [Required(ErrorMessage = "A {0} é obrigatória!")]
        [Display(Name = "Descrição da Classe")]
        public string ClassDescription { get; set; }

        [Required(ErrorMessage = "O {0} é obrigatório!")]
        [Display(Name = "Bônus de Força")]
        public int ClassStr { get; set; }

        [Required(ErrorMessage = "O {0} é obrigatório!")]
        [Display(Name = "Bônus de Vitalidade")]
        public int ClassVit { get; set; }

        [Required(ErrorMessage = "O {0} é obrigatório!")]
        [Display(Name = "Bônus de Inteligência")]
        public int ClassInt { get; set; }

        [Required(ErrorMessage = "O {0} é obrigatório!")]
        [Display(Name = "Bônus de Agilidade")]
        public int ClassAgi { get; set; }

        [Required(ErrorMessage = "O {0} é obrigatório!")]
        [Display(Name = "Bônus de HP")]
        public int ClassHp { get; set; }

        [Required(ErrorMessage = "O {0} é obrigatório!")]
        [Display(Name = "Bônus de MP")]
        public int ClassMp { get; set; }

        public virtual ICollection<Opponent> Opponents { get; set; }
    }
}
