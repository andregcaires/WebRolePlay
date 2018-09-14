using System.Collections.Generic;

namespace RPG.Domain.Models
{
    public class Skill : Entity
    {
        public string SkillName { get; set; }

        public string SkillDescription { get; set; }

        public SkillType SkillType { get; set; }
    }

    public class SkillType : Entity
    {
        public string SkillTypeName { get; set; }

        public virtual ICollection<Skill> Skills { get; set; }
    }
}