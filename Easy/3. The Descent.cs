using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Player
{
    static void Main(String[] args)
    {

        // game loop
        while (true)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int SX = int.Parse(inputs[0]);
            int SY = int.Parse(inputs[1]);
            int[] MH = new int[8];
            for (int i = 0; i < 8; i++)
            {
                MH[i] = int.Parse(Console.ReadLine()); // represents the height of one mountain, from 9 to 0. Mountain heights are provided from left to right.
            }
            
            int[] SortedMH = new int[8];
            Array.Copy(MH, SortedMH, 8);
            
            Array.Sort(SortedMH);
            //Console.Error.WriteLine("Maximum height: " + MH[7]);
            int Maximum = SortedMH[7];

            // Write an action using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");

            //Console.Error.WriteLine(MH[SX]);
            if(MH[SX] == Maximum)
                Console.WriteLine("FIRE"); // either:  FIRE (ship is firing its phase cannons) or HOLD (ship is not firing).
            else
                Console.WriteLine("HOLD");
        }
    }
}