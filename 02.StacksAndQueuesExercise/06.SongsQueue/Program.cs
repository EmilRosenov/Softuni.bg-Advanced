using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

            Queue<string> playlist = new Queue<string>(songs);

            while (playlist.Count>=0)
            {
                string commandInput = Console.ReadLine();
                if (playlist.Count == 0)
                {
                    Console.WriteLine($"No more songs!");
                    return;
                }

                if (commandInput == "Play")
                {
                    playlist.Dequeue();
                }
                
                else if (commandInput == "Show")
                {
                    Console.WriteLine(string.Join(", ", playlist));
                }
                else
                {
                    string[] command = commandInput.Split("Add ");
                    string song = command[1];
                        if (playlist.Contains(song))
                        {
                            Console.WriteLine($"{song} is already contained!");
                        }
                        else
                        {
                            playlist.Enqueue(song);
                        }
                }


            }
            
        }
    }
}
