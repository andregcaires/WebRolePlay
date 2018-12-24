using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RPG.Domain.Models
{
    public class Campaign : Entity
    {
        public virtual Character Master { get; set; }

        public virtual List<Character> Characters { get; set; }

        public virtual List<Opponent> Opponents { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime BeginningDate { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime EndingDate { get; set; }

        public virtual List<CampaignAction> CampaignActions { get; set; }

        public virtual CampaignStatus Status { get; set; }

        public virtual List<Battle> Battles { get; set; }

    }
}