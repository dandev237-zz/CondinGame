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
    ///Returns the alphabet integer position of a character. If the character is not a letter, it returns 27
    ///(the position of '?' in the character array containing the alphabet)
    static int CharacterPosition(char c){
        int position = char.ToUpper(c) - 64;
        return (position >= 1 && position <= 26) ? position : 27;
    }
    
    ///Prints a character
    static void PrintCharacter(char[] characters, int L, int H, int N){
        for (int i = 0; i < H; i++)
        {
            String ROW = Console.ReadLine();
            
            StringBuilder solution = new StringBuilder();
            int count = 0; int character = 0;
            for(int j = 0; j < L*N; j++){
                int position = CharacterPosition(characters[character])*L - L;
                solution.Append(ROW.ElementAt(position+count).ToString());
                count++;
                if(count >= L){
                    count = 0;
                    character++;
                }
            }
            
            Console.WriteLine(solution);
        }
    }

    static void Main(String[] args)
    {
        int L = int.Parse(Console.ReadLine());  //Width of a letter represented in ASCII art.
        int H = int.Parse(Console.ReadLine());  //Height of a letter represented in ASCII art.
        String T = Console.ReadLine();          //Line of text T, composed of N ASCII characters.
        int n = T.Length;                       //Number of characters in T
        
        char[] characters = new char[n];
        StringReader sr = new StringReader(T);
        sr.Read(characters, 0, n);
        
        int count = 0;
        while(count < n){
            PrintCharacter(characters, L, H, n);
            count++;
        }
        
    }
}