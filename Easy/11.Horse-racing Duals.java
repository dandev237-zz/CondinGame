import java.util.*;
import java.io.*;
import java.math.*;

class Solution {

    public static void main(String args[]) {
        Scanner in = new Scanner(System.in);
        int N = in.nextInt();   //Number of horses
        int[] strengths = new int[N];   //Strength values for each horse
        for (int i = 0; i < N; i++) {
            int value = in.nextInt();
            strengths[i] = value;
        }
        
        //First, sort the array
        Arrays.sort(strengths);
        
        //Then look adjacents, storing the minimum difference
        int minimumDifference = 10000000;
        int previousStrength = -1;
        
        for(int strength : strengths){
            if(previousStrength != -1){
                int difference = strength - previousStrength;
                if(difference < minimumDifference){
                    minimumDifference = difference;
                }
            }
            previousStrength = strength;    
        }

        System.out.println(minimumDifference);
    }
}