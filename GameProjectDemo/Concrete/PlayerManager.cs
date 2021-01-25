using GameProjectDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo
{
    public class PlayerManager:BasePlayerManager
    {
        IPlayerCheckService _playerCheckService;

        public PlayerManager(IPlayerCheckService  playerCheckService)
        {
            _playerCheckService = playerCheckService;
        }

        public override void Save(Player player)
        {
            if (_playerCheckService.CheckIfRealPerson(player))
            {
                base.Save(player);
            }
            else
            {
                throw new Exception("Not a valid player");
            }

        }
    }
}
