using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo
{
    public interface IPlayerCheckService
    {
        bool CheckIfRealPerson(Player player);
    }
}
