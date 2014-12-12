using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * The code below will read all the game information for you.
 * On each game turn, information will be available on the standard input, you will be sent:
 * -> the total number of visible enemies
 * -> for each enemy, its name and distance from you
 * The system will wait for you to write an enemy name on the standard output.
 * Once you have designated a target:
 * -> the cannon will shoot
 * -> the enemies will move
 * -> new info will be available for you to read on the standard input.
 **/
class Player{
    
    static void Main(String[] args)
    {
        // game loop
        while (true)
        {
            int count = int.Parse(Console.ReadLine()); // The number of current enemy ships within range
            
            string myTarget = "";
            int minimumDistance = 0;
            
            for (int i = 0; i < count; i++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                String enemy = inputs[0]; // The name of this enemy
                int dist = int.Parse(inputs[1]); // The distance to your cannon of this enemy
                
                if(minimumDistance == 0){
                    minimumDistance = dist;
                    myTarget = enemy;
                }else if(dist < minimumDistance){
                    minimumDistance = dist;
                    myTarget = enemy;
                }
            }

            // Write an action using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");
            
            
            Console.WriteLine(myTarget); // The name of the most threatening enemy (HotDroid is just one example)
        }
    }
}