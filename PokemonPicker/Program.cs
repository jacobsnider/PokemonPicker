using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using PokemonPicker;

namespace PokemonPicker
{
    public class Program
    {
        public const string DIV = "-----------------------------";

        public static void Main(string[] args)
        {
            // Declare out here because it is needed outside of the usings
            List<Pokemon> pokemons;
            List<Pokemon> newTeam = new List<Pokemon>();

            // csv reader needs a stream, so declare that one first then pass that into the csv reader
            using (var streamReader = new StreamReader("pokemon.csv"))

            using (var reader = new CsvReader(streamReader))
            {
                // Register the custom pokemon map
                // That takes care of how the csv file will be mapped to Pokemon
                reader.Configuration.RegisterClassMap<PokemonMap>();

                // Read all of the records and put them into a list
                pokemons = reader.GetRecords<Pokemon>().ToList();
            }

            // Create the menu string
            StringBuilder menu = new StringBuilder();
            menu.Append(DIV)
                .Append("\nMenu\n")
                .Append(DIV)
                .Append("\nEnter 1 to display Pokemon List")
                .Append("\nEnter 2 to display Teams")
                .Append("\nEnter 3 to create a New Team")
                .Append("\nEnter Q to quit");
            // Write the menu
            Console.WriteLine(menu.ToString());

            // Get the first input
            var input = Console.ReadLine();

            // Keep going unless someone enters Q
            while (input.ToUpper() != "Q")
            {
                switch (input)
                {
                    // Print the CSV File List
                    case "1":
                        PrintList(pokemons);
                        break;
                    // Print Team List
                    case "2":
                        PrintTeam(newTeam);
                        break;

                    case "3":
                        newTeam = new List<Pokemon>();
                        
                        // Get the input
                        Console.WriteLine("Enter a Pokemon Name");
                        var firstPokemon = Console.ReadLine();
                        Console.WriteLine("Enter a Pokemon Name");
                        var secondPokemon = Console.ReadLine();
                        Console.WriteLine("Enter a Pokemon Name");
                        var thirdPokemon = Console.ReadLine();
                        Console.WriteLine("Enter a Pokemon Name");
                        var fourthPokemon = Console.ReadLine();
                        Console.WriteLine("Enter a Pokemon Name");
                        var fifthPokemon = Console.ReadLine();
                        Console.WriteLine("Enter a Pokemon Name");
                        var sixthPokemon = Console.ReadLine();

                        //char delimiter = '\,';
                        IEnumerable<Pokemon> matchingLines =
                            pokemons.Where(pokemon =>
                            pokemon.Name == firstPokemon
                            || pokemon.Name == secondPokemon
                            || pokemon.Name == thirdPokemon
                            || pokemon.Name == fourthPokemon
                            || pokemon.Name == fifthPokemon
                            || pokemon.Name == sixthPokemon);

                        using (StreamWriter sw = new StreamWriter("newTeam.txt"))
                        {
                            foreach (var pokemon in matchingLines)
                            {
                                sw.WriteLine(pokemon.Name);
                            }
                        }

                        Console.WriteLine("Team Built Successfully");

                        // Write the menu
                        Console.WriteLine(menu.ToString());

                        break;
                    // If the command isn't one of the designated values, print a nice message
                    default:
                        Console.WriteLine("Command not recognized");
                        break;
                }

                // Get the input
                input = Console.ReadLine();
            }
        }


        // Print the given list
        private static void PrintList(List<Pokemon> pokemons)
        {
            // For all the Pokemon in the list
            foreach (var pokemon in pokemons)
            {
                // Use Pokemons's overriden ToString method
                Console.WriteLine(DIV);
                Console.WriteLine(pokemon.ToString());
                Console.WriteLine(DIV);
            }
        }

        // Print the New Team list
        private static void PrintTeam(List<Pokemon> newTeam)
        {
            using (StreamReader sr = new StreamReader("newTeam.txt"))
            {
                while (!sr.EndOfStream)
                {
                    Console.WriteLine(sr.ReadLine());
                }
            }

        }
    }
}