// See https://aka.ms/new-console-template for more information
using BtgTest.Entities;

public static class Program
{

    public static void Main()
    {
        var player1 = new Player("Adler");
        var player2 = new Player("Ana");
        Random random = new Random();
        player1.Play = (Play)random.Next(1,5);
        player2.Play = (Play)random.Next(1,5);

        var result = DetermineWinner((int)player1.Play, (int)player2.Play);

        PrintWhoWins(player1, player2, result);
    }

    private static int DetermineWinner(int player1, int player2)
    {
        var result1 = (Math.Abs(player1  - player2) % 2);

        switch (result1)
        {
            case 0:
                return player1 == player2? -1 : new[] {player1, player2}.Min();
            case 1:
                return new[] {player1, player2}.Max();
            default:
                throw new Exception("Houve um problema");
        }
    }

    private static void PrintWhoWins(Player player1, Player player2, int result)
    {
        var whoWins = result == -1 ? "Game tied, no one won....." 
        : (result == (int)player1.Play) ? 
            $"{player1.PlayerName} got {player1.Play} and {player2.PlayerName} got {player2.Play}, so {player1.PlayerName} wins!!! " 
            : $"{player1.PlayerName} got {player1.Play} and {player2.PlayerName} got {player2.Play}, so {player2.PlayerName} wins!!! ";

        Console.WriteLine($"\t{whoWins}");
    }
}