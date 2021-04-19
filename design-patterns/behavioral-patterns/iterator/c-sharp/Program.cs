using System;

namespace IteratorDemoConsoleApp
{
    class Program
    {
        static void Main()
        {
            Family family = new Family();

            foreach (FamilyMember member in family)
            {
                Console.WriteLine($"{member.Name}, {member.Age}");
            }
        }
    }
}
