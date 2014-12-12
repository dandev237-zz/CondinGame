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
        string[] inputs = Console.ReadLine().Split(' ');
        int LX = int.Parse(inputs[0]); // the X position of the light of power
        int LY = int.Parse(inputs[1]); // the Y position of the light of power
        int TX = int.Parse(inputs[2]); // Thor's starting X position
        int TY = int.Parse(inputs[3]); // Thor's starting Y position
        
        string Direction = "";

        // game loop
        while (true)
        {
            int E = int.Parse(Console.ReadLine()); // The level of Thor's remaining energy, representing the number of moves he can still make.

            double dX = LX - TX;
            double dY = LY - TY;
            
            if(dX < 0.0 && dY < 0.0){
                Direction = "NW";
            }else
            if(dX < 0.0 && dY > 0.0){
                Direction = "SW";
            }else
            if(dX > 0.0 && dY < 0.0){
                Direction= "NE";
            }else
            if(dX > 0.0 && dY > 0.0){
                Direction = "SE";
            }else{
                if(dX < 0.0){
                    Direction = "W";
                }else if(dX > 0.0){
                    Direction = "E";
                }else{
                    if(dY < 0.0){
                        Direction = "N";
                    }else {
                        Direction = "S";
                    }
                }
            }

            Console.WriteLine(Direction); // A single line providing the move to be made: N NE E SE S SW W or NW
            switch(Direction){
                case "W":
                    TX--;
                    break;
                case "E":
                    TX++;
                    break;
                case "S":
                    TY++;
                    break;
                case "N":
                    TY--;
                    break;
                case "NE":
                    TX++;TY--;
                    break;
                case "SE":
                    TX++;TY++;
                    break;
                case "SW":
                    TX--;TY++;
                    break;
                case "NW":
                    TX--;TY--;
                    break;
                default:
                    break;
            }
        }
    }
}