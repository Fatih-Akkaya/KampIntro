using GameProjectDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Entities
{
    public class Game:IGame
    {
        public int Id { get; set; }
        public string GameName { get; set; }
    }
}
