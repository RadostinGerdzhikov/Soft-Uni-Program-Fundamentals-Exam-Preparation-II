namespace _02_LadyBugEvrethingIsTochno
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class LadyBugEvrethingIsTochno
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            int[] field = new int[size];

            Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Where(i => i >= 0 && i < size)
                .ToList()
                .ForEach(i => field[i] = 1);

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "end")
                {
                    break;
                }

                var commandParts = line.Split(' ');
                var ladyBugIndex = int.Parse(commandParts[0]);
                var direction = commandParts[1];
                var flyLength = int.Parse(commandParts[2]);

                if (direction == "left")
                {
                    flyLength *= -1;
                }

                if (ladyBugIndex < 0 || ladyBugIndex >= size)
                {
                    continue;
                }

                if (field[ladyBugIndex] == 0)
                {
                    continue;
                }

                field[ladyBugIndex] = 0;

                var nextLadyBugFieldLend = ladyBugIndex;

                while (true)
                {
                    nextLadyBugFieldLend += flyLength;

                    if (nextLadyBugFieldLend < 0 || nextLadyBugFieldLend >= size)
                    {
                        break;
                    }
                    if (field[nextLadyBugFieldLend] == 1)
                    {
                        continue;
                    }

                    field[nextLadyBugFieldLend] = 1;
                    break;
                }



            }

            Console.WriteLine(string.Join(" ",field));
       }
    }
}
