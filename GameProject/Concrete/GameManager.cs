using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Entites;

namespace GameProject.Concrete
{
    class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine("Oyun Eklendi");
        }

        public void Delete(Game game)
        {
            Console.WriteLine("Oyun Silindi");
        }

        public void Update(Game game)
        {
            Console.WriteLine("Oyun Güncellendi");
        }
    }
}
