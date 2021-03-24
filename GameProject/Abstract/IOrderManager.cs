using GameProject.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    interface IOrderManager
    {
        void CampaignSale(Gamer gamer, Game game, Campaign campaign);
        void GameSale(Gamer gamer,Game game);


    }
}
