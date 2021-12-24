using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.PokemonTrainer
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,Trainer> trainerList = new Dictionary<string, Trainer>();
            while (true)
            {
                string[] lines = Console.ReadLine().Split();
                if (lines[0]=="Tournament")
                {
                    break;
                }
                //{trainerName}{pokemonName}{pokemonElement}{pokemonHealth}
                string trainerName = lines[0];
                int numberOfBadges = 0;
                string pokemonName = lines[1];
                string pokemonElement = lines[2];
                int pokemonHealth = int.Parse(lines[3]);
                
                if (!trainerList.ContainsKey(trainerName))
                {
                    Trainer newTrainer = new Trainer(trainerName);
                    trainerList.Add(trainerName, newTrainer);
                }

                Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);
                Trainer trainer = trainerList[trainerName];
                trainer.PokemonCollection.Add(pokemon);
            }
            ;
            string command = Console.ReadLine();
            while (command!="End")
            {
                foreach (var trainer in trainerList)
                {
                    if (trainer.Value.PokemonCollection.Any(x=>x.Element==command))
                    {
                        trainer.Value.NumberOfBadges++;
                    }
                    else
                    {
                        trainer.Value.PokemonCollection.ForEach(x => x.Health -= 10);
                        bool IsTrue = trainer.Value.PokemonCollection.Any(x => x.Health <= 0);
                        if (IsTrue)
                        {
                            trainer.Value.PokemonCollection.RemoveAll(x => x.Health <= 0);
                        }
                    }
                }
                command = Console.ReadLine();
            }

            foreach (var trainer in trainerList.OrderByDescending(x=>x.Value.NumberOfBadges))
            {
                Console.WriteLine($"{trainer.Key} {trainer.Value.NumberOfBadges} {trainer.Value.PokemonCollection.Count}");
            }
        }
    }
}
