using System;
using System.Collections.Generic;
using System.Text;

namespace RPG.Domain.Models
{
    public class Opponent
    {
        //public int OpponentId { get; set; }

        public string Name { get; set; }

        public Classes Type { get; set; }

        //elemento?

        public string Photo { get; set; }

        public int Level { get; set; }

        public string Description { get; set; }

        public int Strength { get; set; }

        public int Intelligence { get; set; }

        public int Vitality { get; set; }

        public int Agility { get; set; }

        public int Hp { get; set; }

        public int Mp { get; set; }

    }
}
