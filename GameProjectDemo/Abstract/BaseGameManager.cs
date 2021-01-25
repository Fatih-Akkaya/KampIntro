using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Abstract
{
    public abstract class BaseGameManager : IGameService
    {
        public void Delete(Game game)
        {
            Console.WriteLine("Game deleted.");
        }

        public void Save(Game game)
        {
            Console.WriteLine("Game saved to db :"+game.GameName);
        }

        public void Update(Game game)
        {
            Console.WriteLine("Game updated.");
        }
    }
}
