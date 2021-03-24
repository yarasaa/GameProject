using GameProject.Adapter;
using GameProject.Concrete;
using GameProject.Entites;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer = new Gamer();
            gamer.Id = 1;
            gamer.FirstName = "Mehmet";
            gamer.LastName = "Akbaba";
            gamer.BirthYear = new System.DateTime(1994, 09, 07);
            gamer.IdentityNumber = 265914212212131;

            GamerManager gamerManager = new GamerManager(new MernisServiceAdapter());
            gamerManager.Add(gamer);


            Game game = new Game() { Id = 1, Name = "Skyrim", Price = 50 };

            GameManager gameManager = new GameManager();
            gameManager.Add(game);

            Campaign campaign = new Campaign() { Id = 1, Name = "WinterSale", Discount = 50 };

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign);

            OrderManager orderManager = new OrderManager();
            orderManager.CampaignSale(gamer, game, campaign);
            orderManager.GameSale(gamer, game);
        }
    }
}
