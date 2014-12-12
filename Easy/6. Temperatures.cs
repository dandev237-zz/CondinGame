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
class Solution
{
    static void Main(String[] args)
    {
        int N = int.Parse(Console.ReadLine()); // the number of temperatures to analyse
        
        if(N != 0){
            String TEMPS = Console.ReadLine(); // the N temperatures expressed as integers ranging from -273 to 5526
            
            string[] temperatures = TEMPS.Split(' ');
            int[] TemperatureArray = new int[N];
        
            for(int i = 0; i < N; i++){
                TemperatureArray[i] = int.Parse(temperatures[i]);
            }
        
            int ClosestToZero = 0; //Index of the element which is closest to zero.
            int DistanceClosest = Math.Abs(0 - TemperatureArray[ClosestToZero]);
            for(int i = 0; i < N; i++){
                int DistanceI = Math.Abs(0 - TemperatureArray[i]);
                
                if(DistanceI <= DistanceClosest){
                    ClosestToZero = i;
                    DistanceClosest = Math.Abs(0 - TemperatureArray[ClosestToZero]);
                }
            }
            
            int Result = TemperatureArray[ClosestToZero];
            Console.WriteLine(Result);
        }else{
            Console.WriteLine("0");
        }
    }
}