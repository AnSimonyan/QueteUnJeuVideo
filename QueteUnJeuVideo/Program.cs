namespace QueteUnJeuVideo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Character char1 = new Character("Attacer",3,2,10);
            Character char2 = new Character("Attaced",3,4,2);

            while (char1.isAlive && char2.isAlive)
            {
                char1.Attack(char2);
                char2.Attack(char1);
            }
            string messageOfWinner;

            if (char1.isAlive)
            {
                messageOfWinner = "Winner is: " + char1.Name;
            }
            else if (char2.isAlive)
            {
                messageOfWinner = "Winner is: " + char2.Name;
            }
            else { messageOfWinner = "There is no winners."; }
            

            Console.WriteLine(messageOfWinner);
        }
    }
}
