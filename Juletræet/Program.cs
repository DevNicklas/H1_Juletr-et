using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juletræet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const byte height = 8;
            byte spaces = 8;
            byte treePieces = 1;

            // Loops the height of the tree
            for(int i = 0; i < height; i++)
            {
                // Makes the right amount of spaces from start position
                for(int j = 0; j < spaces; j++)
                {
                    Console.Write(' ');
                }

                // Writes the right amount of tree pieces but only on the lines
                // which is only green. And thats every 2nd line
                if (i % 2 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine(new string('*', treePieces));
                }

                // Writes the right amount of tree pieces in multiple colors but only on
                // the lines which is multiple colored
                else
                {

                    // Loops the amount of tree pieces and writes out the right amount in
                    // the right colors. Either green or red
                    for(int j = 0; j < treePieces; j++)
                    {

                        // Even is green and odd is red. So i just used modulus to 2 and
                        // changed the color to green when the remainder was 0 and red if
                        // the remainder was anything else than 0
                        if (j % 2 == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                        }

                        // Writes the tree piece, since it always has to be printed, in every loop-index
                        Console.Write('*');
                    }

                    // Makes a new line every time the loop of tree pieces is finished
                    Console.WriteLine();
                }

                // Adds 2 to the amount of tree pieces. Since 2 new tree pieces is needed
                // every time a new line is created
                treePieces += 2;

                // Subtracts 1 from amount of spaces for every line
                spaces--;
            }

            // Waits for any user input
            Console.ReadKey();
        }
    }
}
