using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo
{
    public interface IPlayerService
    {
        void Save(Player player);
        void Update(Player player);
        void Delete(Player player);
    }
}
