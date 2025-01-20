namespace RockPaperScissorsLizardSpock
{
    class HumanPlayer{
        private int points;
        public HumanPlayer(int initial){
            points = initial;
        }
        public int GetPoints(){
            return points;
        }
        public void WinRound(){
            points += 5;
        }
        public void LoseRound(){
            points -= 5;
        }
        public string HumanDecision(){
            Console.Write("Please input your choice: Rock, Paper, Scissors, Lizard or Spock: ");
            return Console.ReadLine();
        }
    }

    class ComputerPlayer{
        public string ComputerDecision(){
            Random rnd = new Random();
            int rnd_num = rnd.Next(0, 5);

            if (rnd_num == 0)
                return "Rock";
            else if (rnd_num == 1)
                return "Paper";
            else if (rnd_num == 2)
                return "Scissors";
            else if (rnd_num == 3)
                return "Lizard";
            else
                return "Spock";
        }
    }

    class RockPaperScissorsLizardSpock{
        static void Main(string[] args){
            HumanPlayer human = new HumanPlayer(5);
            ComputerPlayer computer = new ComputerPlayer();
            string userChoice, compChoice;
            int rounds = 0;

            while (human.GetPoints() > 0 && rounds < 3){
                rounds++;
                Console.WriteLine("***Rock, Paper, Scissor, Lizard, Spock, Let’s play!***");
                Console.WriteLine("You have {0} points.", human.GetPoints());
                userChoice = human.HumanDecision();
                compChoice = computer.ComputerDecision();
                Console.WriteLine("--> You shoot: {0}", userChoice);
                Console.WriteLine("--> Computer shoots: {0}", compChoice);

                int winner = DetermineWinner(userChoice, compChoice);
                if (winner == 1){
                    human.WinRound();
                    Console.WriteLine("You Win!");
                    if (userChoice == "Spock")
                    {
                        Console.WriteLine("Spock Wins: 🖖");
                    }
                }
                else if (winner == -1){
                    human.LoseRound();
                    Console.WriteLine("You Lose!");
                    if (compChoice == "Spock")
                    {
                        Console.WriteLine("Spock Wins: 🖖");
                    }
                }
                else{
                    Console.WriteLine("It’s a tie.");
                }

                if (human.GetPoints() == 0){
                    Console.WriteLine("Sorry, you don’t have enough points to continue, thanks for playing.");
                    break;
                }

                Console.Write("--> Play again? Input Y or N to exit. "); 
                string playAgain = Console.ReadLine();
                if (playAgain.ToUpper() != "Y")
                {
                    break;
                }
            }

            if (human.GetPoints() > 0 && rounds >= 3){
                Console.WriteLine("Sorry, you don’t have enough points to continue, thanks for playing.");
            }
        }

        static int DetermineWinner(string userChoice, string compChoice)
        {
            if (userChoice == compChoice) return 0;
            switch (userChoice)
            {
                case "Rock":
                    return (compChoice == "Scissors" || compChoice == "Lizard") ? 1 : -1;
                case "Paper":
                    return (compChoice == "Rock" || compChoice == "Spock") ? 1 : -1;
                case "Scissors":
                    return (compChoice == "Paper" || compChoice == "Lizard") ? 1 : -1;
                case "Lizard":
                    return (compChoice == "Spock" || compChoice == "Paper") ? 1 : -1;
                case "Spock":
                    return (compChoice == "Scissors" || compChoice == "Rock") ? 1 : -1;
                default:
                    throw new InvalidOperationException("Invalid choice.");
            }
        }
    }
}