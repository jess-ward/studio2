using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace studio2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // 1.
            // Array to store frequencies.
            int[] counts = new int[char.MaxValue];
            Console.WriteLine("NEW TEST");
            // 2.
            // Read entire text file.
            string testString = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus."; ;
            string lowerString = testString.ToLower();
            // 3.
            // Iterate over each character.
            foreach (char character in lowerString)
            {
                // Increment table.
                counts[character]++;
            }

            // 4.
            // Write all letters found.
            for (int i = 0; i < char.MaxValue; i++)
            {
                if (counts[i] > 0 &&
                    char.IsLetterOrDigit((char)i))
                {
                    Console.WriteLine($"{(char)i}: {counts[i]}");
                        //(char)i,
                        //c[i]);
                    //string testString = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";

                    //        Dictionary<char, int> counts = new Dictionary<char, int>();

                    //string userInput;

                    //do
                    //{
                    //    Console.WriteLine("Enter a string to see the alphabetic character count:");
                    //    userInput = Console.ReadLine().ToUpper();
                    //    foreach (char c in userInput)
                    //    {
                    //        if (!counts.Keys.Contains(c))
                    //        {
                    //            counts.Add(c, 1);
                    //        }
                    //        else
                    //        {
                    //            counts[c]++;
                    //        }
                    //    }

                    //    foreach (KeyValuePair<char, int> count in counts)
                    //    {
                    //        Console.WriteLine(count.Key + ": " + count.Value);
                    //    }
                    //} while (userInput.Length > 0);



                    //Console.ReadLine();
                }


            }
        }
    }
}


