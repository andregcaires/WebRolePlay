using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RPG.Domain.Models
{
    #region Enums

    public enum Gender
    {
        Female,
        Male
    }
    #endregion

    public class Character : Entity
    {

        public string Name { get; set; }

        public Classes Job { get; set; }

        public int Level { get; set; }

        public string Bio { get; set; }

        public string Photo { get; set; }

        public int Strength { get; set; }

        public int Intelligence { get; set; }

        public int Vitality { get; set; }

        public int Agility { get; set; }

        public int Hp { get; set; }

        public int Mp { get; set; }

    }
}
