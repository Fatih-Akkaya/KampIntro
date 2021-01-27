using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GamerValidationManager : IGamerValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear==1982 && gamer.FirstName=="FATİH" && gamer.LastName=="AKKAYA" && gamer.NationalId=="12345678910")
            { return true; } else { return false;  }
        }
    }
}
