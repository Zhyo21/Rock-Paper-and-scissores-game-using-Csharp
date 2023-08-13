using System;

namespace project_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int PlayerScore = 0;
            int computerScore = 0;
            Console.WriteLine("welcome to rock paper scissors game!");
            while (PlayerScore != 3 && computerScore != 3)
            {
                Console.WriteLine("PlayerScore: " + PlayerScore + "ComputerScore: " + computerScore);

                Console.WriteLine("please enter 'r' for Rock, 'p' for Paper, anything else for scissores");
                string playerch = Console.ReadLine();

                int enemychoise = random.Next(0, 3);

                if (enemychoise == 0)
                {
                    Console.WriteLine("Computer chooses rock.");

                    switch (playerch)
                    {
                        case "r":
                            Console.WriteLine("Tie!");
                            break;


                        case "p":
                            Console.WriteLine("Player won the round!");
                            PlayerScore++;
                            break;


                        default:
                            Console.WriteLine("Computer won the round!");
                            computerScore++;
                            break;
                    }



                }
                if (enemychoise == 1)
                {
                    Console.WriteLine("Computer chooses paper.");
                    switch (playerch)
                    {
                        case "r":
                            Console.WriteLine("Computer won the round!");
                            computerScore++;
                            break;


                        case "p":
                            Console.WriteLine("Tie!");

                            break;


                        default:
                            Console.WriteLine("Player won the round!");
                            PlayerScore++;
                            break;




                    }
                }
                if (enemychoise == 2)
                {
                    Console.WriteLine("Computer chooses scissors.");

                    switch (playerch)
                    {
                        case "r":
                            Console.WriteLine("Player won the round!");
                            PlayerScore++;
                            break;


                        case "p":
                            Console.WriteLine("Computer won the round!");
                            computerScore++;
                            break;


                        default:
                            Console.WriteLine("Tie!");
                            break;


                    }

                }
            }

            if (PlayerScore==3)
            {
                Console.WriteLine("Congrats player won the game!!!");
            }
            else
            {
                Console.WriteLine("You lose,better luck next time!");
            }

        }
    }
}
