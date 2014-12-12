using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

//This code obtained the achievement "Economic"

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Player
{
    static void Main(String[] args)
    {
        string[] inputs;
        int N = int.Parse(Console.ReadLine()); // the number of points used to draw the surface of Mars.
        for (int i = 0; i < N; i++)
        {
            inputs = Console.ReadLine().Split(' ');
            int LAND_X = int.Parse(inputs[0]); // X coordinate of a surface point. (0 to 6999)
            int LAND_Y = int.Parse(inputs[1]); // Y coordinate of a surface point. By linking all the points together in a sequential fashion, you form the surface of Mars.
        }
        
        int MaxHeight = 0; //Auxiliary variable to store the maximum height.

        // game loop
        while (true)
        {
            inputs = Console.ReadLine().Split(' ');
            int X = int.Parse(inputs[0]);
            int Y = int.Parse(inputs[1]);
            int HS = int.Parse(inputs[2]); // the horizontal speed (in m/s), can be negative.
            int VS = int.Parse(inputs[3]); // the vertical speed (in m/s), can be negative.
            int F = int.Parse(inputs[4]); // the quantity of remaining fuel in liters.
            int R = int.Parse(inputs[5]); // the rotation angle in degrees (-90 to 90).
            int P = int.Parse(inputs[6]); // the thrust power (0 to 4).
            if(VS == 0){ //First iteration of the problem
                MaxHeight = Y;
            }
            
            if(Y <= MaxHeight && Y > MaxHeight * 0.9){
                //Do Nothing
            }else{
                if(VS <= -40){
                    P++;
                }else if(VS <= -20){
                    P--;
                }
            }
            
            if(P > 4){
                P = 4;
            }else if(P < 0){
                P = 0;
            }
            Console.WriteLine("0 " + P);
        }
    }
}