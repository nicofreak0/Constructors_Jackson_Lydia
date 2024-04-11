namespace Constructors_Jackson_Lydia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //a game object called myGame with the value of my favorite game and its genre
            Game myGame = new Game("Borderlands", "Science Fiction FPS");

            //prints to console the title and genre of the game object myGame
            Console.WriteLine($"My favorite game is {myGame.title} and it is a {myGame.genre} game!");

            //a game object called myOtherGame
            Game myOtherGame = new Game();

            //prints to console the title and genre of the game object myOtherGame
            Console.WriteLine($"My other favorite game is {myOtherGame.title} and it is rated {myOtherGame.genre}!");
        }
    }
}