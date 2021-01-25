using GameProjectDemo.Abstract;
using GameProjectDemo.Concrete;
using GameProjectDemo.Entities;
using System;

namespace GameProjectDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BasePlayerManager playerManager = new PlayerManager(new PlayerCheckManager());
            Player player = new Player { BirthDay = new DateTime(1982, 1, 1), FirstName = "Fatih", LastName = "Akkaya", NationalId = "12345678910" };
            playerManager.Save(player);

            BaseGameManager gameManager = new GameManager();
            Game game = new Game { Id = 23, GameName = "Black Hawk Down" };
            gameManager.Save(game);

            BaseCampaignManager campaignManager = new CampaignManager();
            Campaign campaign = new Campaign { Id = 5, CampaignName = "İkinci Oyun %50 indirimli", StartDate = new DateTime(2021, 1, 26), EndDate = new DateTime(2021, 2, 26), Discoount = 50 };
            campaignManager.Save(campaign);

            BaseSaleManager saleManager = new SaleManager();
            Sale sale = new Sale { PlayerId = player.Id, GameId = game.Id, CampaignId = campaign.Id, Price = 675, SaleDate = new DateTime() };
            saleManager.Save(sale);
            
        }
    }
}
