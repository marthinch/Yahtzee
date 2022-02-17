using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // [1, 4, 4, 2, 2] [2, 6, 1, 3, 4] [2, 2, 6, 6, 6]
            var listData = new List<List<int>>();

            var sampleData3 = new List<int> { 2, 2, 6, 6, 6 };
            listData.Add(sampleData3);

            var sampleData1 = new List<int> { 2, 6, 1, 3, 4 };
            listData.Add(sampleData1);

            var sampleData2 = new List<int> { 1, 4, 4, 2, 2 };
            listData.Add(sampleData2);

            GetWinner(listData);
        }

        static void GetWinner(List<List<int>> numbersOfDice)
        {
            if (numbersOfDice == null)
                return;

            int highestScore = 0;
            int totalPlayer = numbersOfDice.Count;
            int indexPlayer = 0;

            List<Tuple<string, int>> ranks = new List<Tuple<string, int>>();
            for (int i = 0; i < totalPlayer; i++)
            {
                //var currentScore = numbersOfDice[i].Sum();
                //if (currentScore > highestScore)
                //{
                //    highestScore = currentScore;
                //    indexPlayer = i;

                //    ranks.Add(new Tuple<string, int>(highestScore.ToString(), indexPlayer));
                //}

                var currentScore = numbersOfDice[i].Sum();

                highestScore = currentScore;
                indexPlayer = i;

                ranks.Add(new Tuple<string, int>(highestScore.ToString(), indexPlayer));
            }

            //Console.WriteLine("The winner is player : " + indexPlayer);

            int playerRank = 1;
            var newRanks = ranks.OrderByDescending(a => a).ToList();
            foreach (var rank in newRanks)
            {
                Console.WriteLine(playerRank + " rank is player index : " + rank.Item2 + " with score " + rank.Item1);
                playerRank++;
            }

            Console.ReadKey();
        }
    }
}
