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
    
    ///Counts the number of characters in a string
    static int CountCharactersInString(string s)
    {
        int count = 0;
        foreach(char c in s)
        {
	        if(!char.IsWhiteSpace(c)){
	            result++;
	        }
        }
        return count;
    }
    
    ///Returns the alphabet integer position of a character.
    static int CharacterPosition(char c){
        return char.ToUpper(c) - 64;
    }
    
    ///Main Method
    static void Main(String[] args)
    {
        int L = int.Parse(Console.ReadLine());  //Width of a letter represented in ASCII art.
        int H = int.Parse(Console.ReadLine());  //Height of a letter represented in ASCII art.
        String T = Console.ReadLine();          //Line of text T, composed of n ASCII characters.
        int n = CountCharactersInString(T);
        char[,] abc = new char[H,L*27];
        
        for (int i = 0; i < H; i++){
            String ROW = Console.ReadLine();
            //Console.Error.WriteLine(ROW);
            char[] charRow = ROW.ToCharArray();
            for(int j = 0; j < L*27; j++){
                abc[i,j] = CharRow[j];
                //Console.Error.Write(abc[i,j]);
            }
            //Console.Error.WriteLine("");
        }
        
        char[,] solution = new char[H,N*3];
        //Character printing/Solution making loop - TODO
        
    }
}