namespace ppUke3Kopi
{
    internal class Program
    {
        public class Match
        {
            public int homeGoals { get; private set; }
            public int awayGoals { get; private set; }
            public string homeTeam { get; private set; }
            public string awayTeam { get; private set; }
            public Match(int homeGoals, int awayGoals, string homeTeam, string awayTeam)
            {
                this.homeGoals = homeGoals;
                this.awayGoals = awayGoals;
                this.homeTeam = homeTeam;
                this.awayTeam = awayTeam;
            }
            public void PlayMatch()
            {
                this.homeGoals = RngNum(0, 16);
                this.awayGoals = RngNum(0, 16);
                //Console.Write("Kommandoer: \r\n - H = scoring hjemmelag\r\n - B = scoring bortelag\r\n - X = kampen er ferdig\r\nAngi kommando: ");
                //var command = Console.ReadLine();
                //matchIsRunning = command != "X";
                //if (command == "H") homeGoals++;
                //else if (command == "B") awayGoals++;
                Console.WriteLine($"Stillingen er {homeTeam} {homeGoals} - {awayTeam} {awayGoals}.");

            }
        }
        static void Main(string[] args)
        {
            Console.Write("Gyldig tips: \r\n - H, U, B\r\n - halvgardering: HU, HB, UB\r\n - helgardering: HUB\r\nHva har du tippet for denne kampen? ");
            var betsText = Console.ReadLine();
            var bets = betsText.Split(',');
            string[] teams = {"Argentina", "Tyskland", "Polen", "Kina", "Japan", "Frankrike", "Marseille", "Norge", 
                "SIF", "MIF", "Bulgaria", "USA", "Canada", "Boston", "Protestantene IL", "Ungarn", "Finland", };

            for (int i = 0; i < bets.Length; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Kamp nummer {i + 1}");
                StartMatch(teams, bets[i]);
            }
        }

        static void StartMatch(string[] teams, string bet)
        {
            var homeGoals = 0;
            var awayGoals = 0;
            var awayTeam = teams[RngNum(0, teams.Length)];
            var homeTeam = teams[RngNum(0, teams.Length)];
            var bettingMatch = new Match(homeGoals, awayGoals, homeTeam, awayTeam);
            bettingMatch.PlayMatch();
            CalcMatch(bet, bettingMatch);
        }

        static void CalcMatch(string bet, Match bettingMatch)
        {
            var result = bettingMatch.homeGoals == bettingMatch.awayGoals ? "U" : bettingMatch.homeGoals > bettingMatch.awayGoals ? "H" : "B";
            var isBetCorrect = bet.Contains(result);
            var isBetCorrectText = isBetCorrect ? "riktig" : "feil";
            Console.WriteLine($"Du tippet {isBetCorrectText}");
        }

        public static int RngNum(int min, int max)
        {
            Random random = new Random();
            int num = random.Next(min, max);
            return num;
        }
    }
}