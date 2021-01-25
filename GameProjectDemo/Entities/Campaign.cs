using GameProjectDemo.Abstract;
using System;

namespace GameProjectDemo.Entities
{
    public class Campaign:ICampaign
    {
        public int Id { get; set; }
        public string CampaignName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double Discoount { get; set; }
    }
}