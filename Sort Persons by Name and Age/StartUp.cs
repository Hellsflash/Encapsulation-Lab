using System;
using System.Collections.Generic;

namespace  Sort_Salary_Validation_and_Team
{
    public class StartUp
    {
        public static void Main()
        {
            var inputNum = int.Parse(Console.ReadLine());
            var firstTeam =new Team("firstTeam");
            var reserveTeam = new Team("reserveTeam");
            for (int i = 0; i < inputNum; i++)
            {
                var inputArgs = Console.ReadLine().Split();
                firstTeam.AddPlayer(new Person(inputArgs[0],inputArgs[1],int.Parse(inputArgs[2]),double.Parse(inputArgs[3])));
                reserveTeam.AddPlayer(new Person(inputArgs[0], inputArgs[1], int.Parse(inputArgs[2]), double.Parse(inputArgs[3])));
            }

            Console.WriteLine($"First team have { firstTeam.FirstTeam.Count} players");
            Console.WriteLine($"Reserve team have {reserveTeam.ReserveTeam.Count} players");
        }

    }
}
