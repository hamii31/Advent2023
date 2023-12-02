namespace Advent2023
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //only 12 red cubes, 13 green cubes, and 14 blue cubes
            string input = "Game 1: 8 green; 5 green, 6 blue, 1 red; 2 green, 1 blue, 4 red; 10 green, 1 red, 2 blue; 2 blue, 3 red\r\nGame 2: 10 blue, 12 red; 8 red; 7 green, 5 red, 7 blue\r\nGame 3: 1 red, 15 blue, 3 green; 8 blue, 2 red, 4 green; 2 red, 5 green, 9 blue\r\nGame 4: 8 green, 4 blue, 1 red; 3 green; 4 blue, 1 red, 12 green; 5 green, 1 red, 8 blue; 3 green, 5 blue, 1 red\r\nGame 5: 2 green, 8 blue; 7 blue, 4 green; 7 blue; 5 blue; 5 green, 2 blue, 1 red\r\nGame 6: 6 blue, 3 green; 18 green, 8 blue; 9 green, 4 blue; 4 blue, 2 red, 3 green\r\nGame 7: 15 red, 12 blue, 15 green; 12 blue, 18 green; 9 blue, 11 red; 16 green, 6 blue, 18 red; 6 blue, 12 red; 14 red, 18 green, 12 blue\r\nGame 8: 6 red, 13 blue, 3 green; 18 blue; 3 green, 8 red\r\nGame 9: 3 blue, 4 red; 8 red, 2 blue; 4 green, 8 red, 3 blue; 6 red, 1 blue; 16 green, 2 red, 2 blue\r\nGame 10: 3 red, 7 blue, 2 green; 1 green, 15 red, 5 blue; 1 red, 5 blue; 3 blue, 4 green\r\nGame 11: 12 green, 3 blue; 3 red; 1 red, 6 blue, 9 green; 7 blue, 1 red, 13 green; 1 blue, 5 green, 4 red; 18 green, 3 red\r\nGame 12: 9 green, 13 blue; 3 red, 4 blue, 4 green; 10 green, 7 red, 5 blue; 9 red, 12 blue, 3 green\r\nGame 13: 15 red, 18 blue, 10 green; 11 red, 3 green, 4 blue; 2 green, 12 blue, 4 red\r\nGame 14: 12 blue, 6 red; 2 blue, 7 green, 6 red; 12 blue, 7 green; 4 blue, 1 green, 4 red; 9 green, 12 blue; 3 red, 5 green, 8 blue\r\nGame 15: 9 green, 1 blue; 14 green, 4 red, 1 blue; 1 blue, 6 green, 2 red; 7 red, 13 green, 2 blue; 4 red, 9 green; 2 green, 1 blue, 2 red\r\nGame 16: 3 blue, 2 green, 5 red; 4 green, 3 blue, 4 red; 6 red, 5 blue, 2 green; 3 red, 11 blue; 6 green, 15 blue, 4 red\r\nGame 17: 15 blue, 3 green, 2 red; 2 green, 2 red, 15 blue; 1 red, 1 blue, 7 green\r\nGame 18: 2 blue, 9 red; 12 red, 1 green, 6 blue; 5 red, 5 blue, 2 green\r\nGame 19: 3 red, 4 green, 8 blue; 10 red, 8 green, 1 blue; 13 blue, 7 green, 10 red; 6 red, 1 green, 11 blue; 9 green, 7 blue, 10 red; 7 blue, 7 red\r\nGame 20: 8 blue, 4 green, 14 red; 4 green, 16 red, 1 blue; 10 blue, 14 red, 8 green; 4 green, 13 blue, 20 red; 5 blue, 5 green, 1 red\r\nGame 21: 4 green, 10 blue, 5 red; 11 blue, 4 green, 1 red; 3 blue, 3 red, 2 green; 1 red, 11 blue, 6 green; 1 green, 9 blue, 5 red; 7 blue, 5 green\r\nGame 22: 3 green, 7 blue, 6 red; 12 red, 11 blue, 2 green; 1 blue, 1 green, 15 red; 6 blue, 1 green, 8 red; 4 blue, 1 red; 2 blue, 1 green, 5 red\r\nGame 23: 2 blue, 5 green, 13 red; 1 green, 5 blue, 16 red; 6 blue, 9 green, 9 red; 7 green, 3 blue\r\nGame 24: 2 green; 2 red, 7 blue, 17 green; 5 red, 6 blue, 13 green; 1 green, 6 blue; 2 green, 4 red, 2 blue; 4 blue, 2 green\r\nGame 25: 2 green, 5 blue, 9 red; 2 green, 8 red, 5 blue; 3 green, 1 red, 19 blue\r\nGame 26: 3 green, 2 blue, 8 red; 4 red, 2 blue; 11 red, 3 green; 9 red, 3 green, 6 blue; 10 red, 1 green, 2 blue; 4 blue, 4 green, 14 red\r\nGame 27: 1 green, 4 red, 7 blue; 13 red; 17 red\r\nGame 28: 5 red, 17 green, 15 blue; 7 blue; 7 red, 12 green, 10 blue; 5 red, 11 blue, 3 green\r\nGame 29: 4 blue, 9 red, 9 green; 2 green, 10 red, 2 blue; 3 red, 4 blue, 6 green; 2 green, 17 red, 1 blue; 2 red, 7 green, 1 blue\r\nGame 30: 16 red, 5 blue, 11 green; 5 blue, 5 green, 9 red; 7 green, 1 red, 6 blue\r\nGame 31: 3 green, 11 blue; 5 green; 8 green, 13 blue; 4 red, 10 blue, 8 green\r\nGame 32: 11 blue, 5 green, 4 red; 7 blue; 1 red, 1 green, 7 blue; 7 red, 1 blue, 4 green\r\nGame 33: 7 red, 3 green, 6 blue; 2 red, 16 green, 5 blue; 1 blue, 2 red, 8 green\r\nGame 34: 1 blue, 1 red, 1 green; 9 red, 6 green; 2 blue, 8 red, 6 green; 1 blue, 12 green, 13 red\r\nGame 35: 10 red, 9 green; 1 red, 4 blue, 4 green; 7 blue, 3 green, 4 red\r\nGame 36: 5 red, 6 green, 4 blue; 9 green, 1 red; 12 red, 12 green, 4 blue; 3 red; 18 green, 5 red, 4 blue\r\nGame 37: 10 green, 4 blue, 2 red; 1 red, 3 blue, 9 green; 5 blue, 4 green, 1 red; 6 green, 12 blue; 7 green, 1 red, 13 blue; 9 green, 20 blue, 2 red\r\nGame 38: 9 blue, 20 red, 2 green; 3 blue, 6 green, 19 red; 10 green, 8 red, 2 blue; 4 blue, 4 red, 3 green\r\nGame 39: 4 green, 2 blue, 4 red; 16 blue, 1 red, 2 green; 13 red, 2 green; 16 blue, 7 red, 3 green\r\nGame 40: 8 blue, 2 green, 2 red; 7 blue, 2 red, 1 green; 8 green, 12 blue, 2 red; 2 red, 3 blue, 8 green\r\nGame 41: 9 blue, 2 green; 10 blue, 3 green; 1 green, 9 blue, 3 red; 3 blue, 3 green; 12 blue, 1 red; 3 blue, 1 green, 1 red\r\nGame 42: 1 blue, 1 green, 8 red; 1 blue, 1 red; 2 red, 1 green\r\nGame 43: 5 red, 2 green, 8 blue; 11 blue, 10 green, 1 red; 11 blue, 7 red\r\nGame 44: 9 red, 3 green; 9 red, 1 blue, 6 green; 14 red, 5 green; 4 red, 2 green, 1 blue\r\nGame 45: 5 blue, 1 red, 1 green; 5 blue, 1 red; 6 blue; 10 blue, 1 green; 1 red\r\nGame 46: 4 green, 8 blue, 13 red; 12 green, 11 blue, 12 red; 1 green, 13 red, 1 blue; 12 red, 8 green, 12 blue\r\nGame 47: 1 green, 16 blue, 15 red; 1 blue; 18 red, 10 blue, 9 green; 17 blue, 16 red, 5 green; 2 red, 3 blue, 9 green\r\nGame 48: 2 blue, 4 green; 7 blue, 3 red, 2 green; 17 blue, 13 red; 2 red, 1 green, 9 blue; 2 red, 14 blue\r\nGame 49: 6 red, 2 blue, 3 green; 1 green, 4 blue, 7 red; 5 red, 8 green, 6 blue; 1 red, 9 green\r\nGame 50: 18 red, 4 blue; 6 blue, 3 green, 13 red; 1 green, 7 red, 6 blue\r\nGame 51: 10 blue, 1 green, 9 red; 3 green, 6 blue, 8 red; 4 red, 2 green, 12 blue\r\nGame 52: 7 blue, 1 red, 8 green; 2 red, 9 blue, 8 green; 16 blue, 7 green; 1 red, 11 green, 8 blue; 2 red, 20 blue\r\nGame 53: 8 green, 15 red, 4 blue; 5 green, 13 blue; 6 blue, 6 green, 15 red; 12 blue, 2 green, 2 red\r\nGame 54: 3 green, 5 red, 1 blue; 1 blue, 6 green, 2 red; 4 green, 3 red\r\nGame 55: 12 green, 8 red, 3 blue; 6 blue, 2 red, 7 green; 4 blue, 13 red, 11 green; 12 green, 9 blue, 7 red; 10 red, 6 blue, 3 green\r\nGame 56: 6 red, 1 green, 2 blue; 1 red, 1 green, 3 blue; 12 red, 4 blue, 4 green; 3 green, 5 blue, 1 red; 5 blue, 3 green, 2 red; 1 green, 5 red, 7 blue\r\nGame 57: 1 blue, 1 green, 3 red; 10 red, 6 green, 1 blue; 4 red, 4 green, 2 blue; 7 green, 2 blue, 1 red\r\nGame 58: 5 green, 2 blue, 4 red; 2 red, 2 blue; 5 red, 3 green; 3 blue, 5 green; 6 red, 2 green, 2 blue; 7 red, 3 blue, 5 green\r\nGame 59: 14 red, 9 green; 11 red, 2 blue, 5 green; 18 red, 2 blue, 4 green\r\nGame 60: 16 red, 9 green, 2 blue; 8 green, 17 red; 3 blue, 5 green, 14 red\r\nGame 61: 12 red, 17 blue, 18 green; 1 green, 1 blue; 1 blue, 4 green, 6 red\r\nGame 62: 2 blue, 5 green, 3 red; 1 blue, 7 green, 6 red; 8 blue, 1 red; 4 blue, 5 red, 12 green; 15 blue, 3 green, 1 red\r\nGame 63: 2 blue, 2 red, 1 green; 5 red, 10 blue, 4 green; 4 green, 5 blue, 8 red\r\nGame 64: 2 blue, 14 green; 9 green, 5 red; 7 red, 3 blue, 10 green; 14 green, 2 blue, 5 red\r\nGame 65: 4 green, 7 blue, 1 red; 3 red, 2 green, 7 blue; 5 blue, 2 red, 1 green; 6 blue, 2 green; 7 blue\r\nGame 66: 9 red, 2 green, 5 blue; 5 blue; 8 blue, 5 green, 11 red; 17 blue, 3 green, 14 red; 2 green, 9 blue; 11 red, 4 blue\r\nGame 67: 2 green, 7 red, 8 blue; 6 red, 4 green; 1 red, 3 green, 7 blue; 7 blue, 7 red, 4 green; 2 red, 1 green; 3 green, 6 red, 2 blue\r\nGame 68: 4 red, 2 blue, 5 green; 5 blue, 8 red, 2 green; 11 red, 2 green, 4 blue; 7 red, 5 blue, 3 green\r\nGame 69: 8 blue, 1 green, 4 red; 3 red, 11 blue, 9 green; 12 blue, 10 green; 1 red, 15 blue, 7 green\r\nGame 70: 13 blue, 1 green, 8 red; 15 blue, 10 red; 10 blue, 17 red; 15 red, 4 green, 6 blue; 11 red, 1 blue, 2 green; 14 red, 4 green, 4 blue\r\nGame 71: 1 red, 10 blue; 1 green, 12 blue, 2 red; 4 red, 4 green, 8 blue\r\nGame 72: 2 green, 6 red, 1 blue; 7 red, 4 green, 4 blue; 7 red, 4 blue, 7 green; 7 green, 3 blue; 10 green, 9 blue, 8 red; 5 red, 2 green, 8 blue\r\nGame 73: 8 blue, 2 green, 9 red; 2 green, 10 red, 6 blue; 3 blue, 6 green, 2 red\r\nGame 74: 2 blue, 10 green, 7 red; 4 blue, 13 red, 3 green; 11 green, 3 red, 4 blue\r\nGame 75: 14 green, 1 red, 7 blue; 15 blue, 11 green, 1 red; 11 green, 15 blue, 6 red\r\nGame 76: 7 green, 7 red, 2 blue; 4 blue, 18 red, 9 green; 12 red, 4 blue, 1 green\r\nGame 77: 3 blue, 1 green, 12 red; 10 green, 13 red, 7 blue; 7 green, 12 red; 6 blue, 10 red; 5 blue, 3 green, 17 red; 3 green, 5 blue, 13 red\r\nGame 78: 11 red, 9 blue; 2 red, 7 blue; 12 red, 7 blue, 3 green; 3 green, 8 red, 9 blue; 1 green, 5 red, 6 blue\r\nGame 79: 6 red, 12 blue; 5 red, 4 green, 11 blue; 13 blue, 2 green, 3 red\r\nGame 80: 7 red, 6 blue; 2 green, 7 red, 6 blue; 5 blue, 6 red, 2 green; 1 green, 7 red, 2 blue; 4 green, 6 blue, 7 red; 1 green, 6 red, 10 blue\r\nGame 81: 10 blue, 7 green, 3 red; 7 green, 3 red, 16 blue; 18 blue, 3 red, 7 green\r\nGame 82: 7 red, 5 blue, 9 green; 7 blue, 8 green, 11 red; 1 blue, 1 green, 10 red; 5 red, 8 blue, 7 green; 6 red, 10 green, 2 blue; 3 blue, 5 green, 10 red\r\nGame 83: 2 red, 2 green, 1 blue; 2 green, 2 red; 6 red, 1 green; 8 red, 1 blue, 1 green; 1 red, 1 green; 3 red\r\nGame 84: 9 red, 4 green; 1 red, 13 green, 2 blue; 2 green, 15 red, 2 blue\r\nGame 85: 2 green, 4 red; 1 blue; 2 green, 4 red, 1 blue\r\nGame 86: 2 green, 10 red, 3 blue; 3 red, 5 blue; 3 green, 2 blue, 8 red; 1 blue, 5 red, 2 green\r\nGame 87: 19 green, 9 blue, 7 red; 12 red, 15 green; 4 blue, 8 green; 6 green, 3 red, 11 blue; 16 green, 4 blue, 11 red; 10 red, 4 blue, 9 green\r\nGame 88: 6 red, 2 green; 10 red, 4 green, 4 blue; 1 blue, 8 red, 12 green; 7 green, 2 blue, 12 red; 1 green, 5 blue, 16 red; 10 red, 5 blue\r\nGame 89: 1 red, 14 blue, 1 green; 1 red, 12 blue, 8 green; 2 red, 13 blue, 11 green; 8 blue, 4 red, 16 green; 4 red, 5 blue; 6 blue, 1 red, 1 green\r\nGame 90: 3 blue, 9 green, 5 red; 4 green, 6 red, 1 blue; 2 blue, 12 green, 5 red; 1 green, 1 blue, 3 red; 5 red, 3 green\r\nGame 91: 8 green, 3 blue, 8 red; 8 green, 4 blue, 4 red; 5 red, 1 green\r\nGame 92: 1 green, 9 red; 1 red, 4 blue; 9 red, 2 green; 3 red, 1 blue\r\nGame 93: 1 red, 16 green, 5 blue; 1 red, 1 green, 4 blue; 4 blue, 6 red, 13 green\r\nGame 94: 9 red, 9 blue, 3 green; 5 green, 11 blue, 1 red; 3 red, 6 blue\r\nGame 95: 2 green, 4 blue; 8 green, 2 blue, 12 red; 10 red, 9 green; 4 red, 2 blue, 4 green; 8 blue, 7 green, 14 red; 1 blue, 4 red, 8 green\r\nGame 96: 12 red, 2 blue, 8 green; 6 green, 6 red; 7 blue, 8 green, 6 red; 14 red, 8 green; 2 blue, 4 green, 10 red; 6 green, 7 blue, 7 red\r\nGame 97: 4 green, 12 red, 2 blue; 8 blue, 3 red, 3 green; 2 blue, 2 red, 7 green; 17 blue, 1 green, 7 red; 19 blue, 1 red, 6 green; 6 green, 7 red, 9 blue\r\nGame 98: 13 red, 15 green, 14 blue; 6 blue, 1 green; 14 blue, 12 red, 1 green\r\nGame 99: 1 green, 11 red, 12 blue; 7 red, 20 blue, 1 green; 5 blue, 5 red; 6 blue, 4 red; 1 blue, 1 green; 6 red, 8 blue\r\nGame 100: 2 red, 9 green, 11 blue; 13 blue, 4 red, 16 green; 8 green, 13 blue; 10 green, 1 red, 12 blue";
            string testInput = "Game 1: 3 blue, 4 red; 1 red, 2 green, 6 blue; 2 green\r\nGame 2: 1 blue, 2 green; 3 green, 4 blue, 1 red; 1 green, 1 blue\r\nGame 3: 8 green, 6 blue, 20 red; 5 blue, 4 red, 13 green; 5 green, 1 red\r\nGame 4: 1 green, 3 red, 6 blue; 3 green, 6 red; 3 green, 15 blue, 14 red\r\nGame 5: 6 red, 1 blue, 3 green; 2 blue, 1 red, 2 green";

            int sumOfGames = 0;
            
            List<string> inputList = input.Split("\r\n").ToList();
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();

            var doubleDigits = false;
            var tripleDigits = false;

            foreach (string line in inputList)
            {
                var key = "";
                var value = "";

                if (doubleDigits)
                {
                     key = line.Substring(0, 7);
                     value = line.Substring(9);
                }
                else if (tripleDigits)
                {
                    key = line.Substring(0, 8);
                    value = line.Substring(10);
                }
                else
                {
                    key = line.Substring(0, 6);
                    value = line.Substring(8);
                }

                var splitted = key.Split(" ");

                if (int.Parse(splitted[1]) == 9)
                {
                    doubleDigits = true;
                }
                if (int.Parse(splitted[1]) == 99)
                {
                    doubleDigits = false;
                    tripleDigits = true;
                }

                if (!dict.ContainsKey(key))
                {
                    dict[key] = value.Split("; ").ToList();
                }
            }

            List<string> colors = new List<string>();

            foreach (var key in dict)
            { 
                var count = 0;

                foreach (var line in key.Value)
                {
                    var sumOfReds = 0;
                    var sumOfGreens = 0;
                    var sumOfBlues = 0;

                    if (!line.Contains(","))
                    {
                        var splitted = line.Split(' ');
                        var num = splitted[0];
                        var color = splitted[1];

                        switch (color)
                        {
                             case "green":
                               
                                sumOfGreens += int.Parse(num);
                                break;
                             case "blue":

                                sumOfBlues += int.Parse(num);
                                break;
                             case "red":

                                sumOfReds += int.Parse(num);
                                break;
                        }
                    }
                    else
                    {
                        colors = line.Split(", ").ToList();

                        for (int i = 0; i < colors.Count; i++)
                        {
                            var splitted = colors[i].Split(' ');
                            var num = splitted[0];
                            var color = splitted[1];

                            switch (color)
                            {
                                case "green":

                                    sumOfGreens += int.Parse(num);
                                    break;
                                case "blue":

                                    sumOfBlues += int.Parse(num);
                                    break;
                                case "red":

                                    sumOfReds += int.Parse(num);
                                    break;
                            }

                        }
                    }
                    if (sumOfReds <= 12 && sumOfGreens <= 13 && sumOfBlues <= 14)
                    {
                        count++;
                    }
                    colors.Clear();
                }

                if (count == key.Value.Count)
                {
                    var splitted = key.Key.Split(' ');
                    var num = splitted[1];

                    sumOfGames += int.Parse(num);
                    Console.WriteLine(key.Key);
                }
               
            }
            Console.WriteLine(sumOfGames);
        }
    }
}
