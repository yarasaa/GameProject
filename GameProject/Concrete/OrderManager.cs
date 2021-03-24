﻿using GameProject.Abstract;
using GameProject.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class OrderManager : IOrderManager
    {
        public void CampaignSale(Gamer gamer, Game game, Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " " + game.Name + " için " + gamer.FirstName + " adlı oyuncuya uygulanmıştır");
        }

        public void GameSale(Gamer gamer, Game game)
        {
            Console.WriteLine(game.Name + " ," + gamer.FirstName + " " + gamer.LastName + " " + "adlı oyuncuya satılmıştır");
        }

    }
}
