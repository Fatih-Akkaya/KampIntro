using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GamerManager : IGamerService
    {
        IGamerValidationService _gamerValidationService;

        public GamerManager(IGamerValidationService gamerValidationService)
        {
            _gamerValidationService = gamerValidationService;
        }
        public void Add(Gamer gamer)
        {
            if(_gamerValidationService.Validate(gamer))
            { 
                Console.WriteLine("Oyuncu eklendi"); 
            } else { 
                Console.WriteLine("Oyuncu eklenemedi"); 
            }
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Oyuncu silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Oyuncu güncellendi");
        }
    }
}
