using System;
namespace GameProjectDemo
{
    public class Player:IPlayer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDay { get; set; }
        public string NationalId { get; set; }
    }
}