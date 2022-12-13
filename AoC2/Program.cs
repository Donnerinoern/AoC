namespace AoC2
{
    class Program
    {
        public static void Main()
        {
            string[] lines = File.ReadAllLines("/home/donnan/RiderProjects/AoC/AoC2/input2.txt");
            string[] round;
            int roundPoints = 0;
            int totalPoints = 0;
            foreach (var line in lines)
            {
                Hand opponentHand;
                Hand yourHand;
                round = line.Split(" ");
                opponentHand = ConvertToHand(round[0]);
                yourHand = ConvertToHand(round[1]);
                roundPoints = CalculateScore(opponentHand, yourHand);
                totalPoints += roundPoints;
                Console.WriteLine(roundPoints);
            }
            Console.WriteLine(totalPoints);
        }

        public static int CalculateScore(Hand opponent, Hand you)
        {
            if (opponent == you)
            {
                return (int)(you + 3);
            }

            if (opponent == Hand.Scissors && you == Hand.Paper || opponent == Hand.Paper && you == Hand.Rock || opponent == Hand.Rock && you == Hand.Scissors)
            {
                return (int)(you + 0);
            }
            return (int)(you + 6);
        }
        /*
        public Outcome CheckOutcome(String opponent, String you)
        {
            
        }*/

        public static Hand ConvertToHand(String answer)
        {
            if (answer == "X" || answer == "A")
            {
                return Hand.Rock;
            }
            if (answer == "Y" || answer == "B")
            {
                return Hand.Paper;
            }
            if (answer == "Z" || answer == "C")
            {
                return Hand.Scissors;
            }
            return Hand.Error;
        }
    }
}

