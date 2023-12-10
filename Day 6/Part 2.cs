using System.Numerics;
using System.Security.Cryptography;

namespace Advent2023
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* time held the button X remaining time = distance traveled 
             If you hold the button 0s the boat wont move
            if you hold the button for the total remainder of the race, the boat wont move*/

            string testInput = "Time:      51926890\r\nDistance:  222203111261225";

            Dictionary<BigInteger, BigInteger> records = new Dictionary<BigInteger, BigInteger>();

            List<string> list = testInput.Split("\r\n").ToList();

            List<string> times = list[0].Split(" ").ToList();
            List < string> distances = list[1].Split(" ").ToList();

            int count = 0;
            foreach ( var t in times )
            {
                if(BigInteger.TryParse(t, out _))
                {
                    if (!records.ContainsKey(BigInteger.Parse(t)))
                    {
                        count++;
                        FeedDistances(distances, records, BigInteger.Parse(t), count);
                    }
                } 
            }


            var recordCount = 0;

            foreach (var key in records)
            {
                var matchCount = 0;
                BigInteger distance = 0;

                for (var i = 0; i <= key.Key; i++)
                {
                    if (i != 0 && i != key.Key)
                    {
                        distance = i * (key.Key - i);

                        if (distance > key.Value)
                        {
                            matchCount++;
                        }
                    }
                }

                if (recordCount == 0)
                {
                    recordCount = matchCount;
                }
                else
                {
                    recordCount *= matchCount;
                }
            }

            Console.WriteLine(recordCount);
        }

        private static void FeedDistances(List<string> distances, Dictionary<BigInteger, BigInteger> records, BigInteger key, int count)
        {
            int counter = 0;
            foreach ( var d in distances )
            {
                if (BigInteger.TryParse(d, out _))
                {
                    counter++;
                    if(counter == count)
                    {
                        records[key] = BigInteger.Parse(d);
                    }
                }
            }
        }
    }
}
