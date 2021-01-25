using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Abstract
{
    public abstract class BasePlayerManager : IPlayerService
    {
        public void Delete(Player player)
        {
            Console.WriteLine("Deleted from db : " + player.FirstName);
        }

        public virtual void Save(Player player)
        {
            Console.WriteLine("Saved to db : " + player.FirstName);
        }

        public void Update(Player player)
        {
            Console.WriteLine("Updated on db : " + player.FirstName);
        }
    }
}
