using System;

namespace ExplicitInterfaces
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string inputCitizen;
            while ((inputCitizen = Console.ReadLine()) != "End")
            {
                var tokens = inputCitizen.Split(' ');
                var citizen = new Citizen(tokens[0], tokens[1], int.Parse(tokens[2]));
                IResident resident = citizen;
                IPerson person = citizen;

                Console.WriteLine(person.GetName());
                Console.WriteLine(resident.GetName());
            }
        }
    }
}
