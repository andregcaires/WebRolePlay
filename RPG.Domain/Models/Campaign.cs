using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RPG.Domain.Models
{
    public class Campaign : Entity
    {
        public virtual List<Character> Characters { get; set; }

        public virtual List<Opponent> Opponents { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime BeginningDate { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime EndingDate { get; set; }

        public virtual List<CampaignAction> CampaignActions { get; set; }

        public virtual Status Status { get; set; }
    }
}