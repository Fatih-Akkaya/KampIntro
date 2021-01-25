using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo
{
    class PlayerCheckManager : IPlayerCheckService
    {
        public bool CheckIfRealPerson(Player player)
        {
            return true;
        }
    }
}
