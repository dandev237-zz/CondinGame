import java.util.*;
import java.io.*;
import java.math.*;

class Solution {
    
    public static final int ASCII_CHARACTER_SIZE = 7;

    public static void main(String args[]) {
        Scanner in = new Scanner(System.in);
        String MESSAGE = in.nextLine();
        
        String binaryVersion = "";
        
        for(char c: MESSAGE.toCharArray()){
            String binaryChar = Integer.toBinaryString(c);
            //Padding
            while (binaryChar.length() < ASCII_CHARACTER_SIZE) {
                binaryChar = "0" + binaryChar;
            }
            binaryVersion += binaryChar;
        }
        
        //Random value to check if we have read any character
        //prior to inserting a whitespace
        char read = '9';

        for(char c: binaryVersion.toCharArray()){
            if(c == read){
                System.out.print("0");
            }else{
                if(read != '9'){
                    System.out.print(" ");
                }
                read = c;
                
                if(c == '1'){
                    System.out.print("0 ");
                    read = '1';
                }else if(c == '0'){
                    System.out.print("00 ");
                    read = '0';
                }
                System.out.print("0");
            }
        }
    }
}