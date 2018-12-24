using System;
using System.Collections.Generic;
using System.Text;

namespace RPG.Domain.Models
{
    /*
    * não iniciada, em andamento, encerrada 
    */
    public class CampaignStatus : Entity
    {
        public string Name { get; set; }
    }
}
