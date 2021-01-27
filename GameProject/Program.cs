using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new GamerValidationManager());
            gamerManager.Add(new Gamer { BirthYear = 1992, FirstName = "FATİH", LastName = "AKKAYA", NationalId = "12345678910" });
        }
    }
}
