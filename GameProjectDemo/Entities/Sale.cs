using GameProjectDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Entities
{
    public class Sale:ISale
    {
        public int Id { get; set; }
        public int PlayerId { get; set; }
        public int GameId { get; set; }
        public int CampaignId { get; set; }
        public DateTime SaleDate { get; set; }
        public double Price { get; set; }
    }
}
