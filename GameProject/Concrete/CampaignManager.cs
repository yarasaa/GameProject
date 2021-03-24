using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Entites;

namespace GameProject.Concrete
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Kampanya Eklendi");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Kampanya Silindi");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Kampanya Güncellendi");
        }
    }
}
