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
        int R = int.Parse(Console.ReadLine()); // the length of the road before the gap.
        int G = int.Parse(Console.ReadLine()); // the length of the gap.
        int L = int.Parse(Console.ReadLine()); // the length of the landing platform.
        
        string Command = "";
        bool Jumped = false;
        
        

        // game loop
        while (true)
        {
            int S = int.Parse(Console.ReadLine()); // the motorbike's speed.
            int X = int.Parse(Console.ReadLine()); // the position on the road of the motorbike.
            
            if((X+S>R) && !Jumped){
                Command = "JUMP";
                Jumped = true;
            }else if(Jumped || (!Jumped && S>G+1)){
                Command = "SLOW";
            }else if(S >= G + 1 && !Jumped){
                Command = "WAIT";
            }else{
                Command = "SPEED";
            }
    
            Console.WriteLine(Command); // A single line containing one of 4 keywords: SPEED, SLOW, JUMP, WAIT.
        }
    }
}