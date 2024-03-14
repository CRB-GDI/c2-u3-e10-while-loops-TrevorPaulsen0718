namespace Demo_Exercise10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int enemies = 18;
            int playerHP = 10;


            while (enemies > 0 && playerHP > 5)
                {
                //Attack Enemies
                enemies--;
                Console.WriteLine("Enemies left: " + enemies);
                // Random damage to player may reduce HP

                } // End of while loop

                if (enemies <= 0);
                {
                Console.WriteLine("Congratulations, you win!");
                }
                else
                {
                Console.WriteLine("You Lose Game Over");
                }
                }

            }
        }
    }
}