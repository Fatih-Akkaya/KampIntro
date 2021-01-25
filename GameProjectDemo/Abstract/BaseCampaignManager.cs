using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Abstract
{
    public abstract class BaseCampaignManager : ICampaignService
    {
        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Campaign Deleted from db : " + campaign.CampaignName);
        }

        public void Save(Campaign campaign)
        {
            Console.WriteLine("Campaign saved to db : " + campaign.CampaignName);
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Campaign updated on db : " + campaign.CampaignName);
        }
    }
}
