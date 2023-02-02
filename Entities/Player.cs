namespace BtgTest.Entities
{
    public class Player
    {
        public string? PlayerName { get; set; }
        public Play Play { get; set; }
        public Player(string playerName)
        {
            PlayerName = playerName;
        }
    }
}