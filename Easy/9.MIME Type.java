import java.util.*;
import java.io.*;
import java.math.*;

class Solution {

    public static void main(String args[]) {
        Scanner in = new Scanner(System.in);
        int N = in.nextInt(); // Number of elements which make up the association table.
        int Q = in.nextInt(); // Number Q of file names to be analyzed.
        Map<String, String> typeDictionary = new HashMap<String, String>();
        for (int i = 0; i < N; i++) {
            String EXT = in.next(); // file extension
            String MT = in.next(); // MIME type.
            System.err.println(EXT + " " + MT);
            typeDictionary.put(EXT.toLowerCase(), MT);
            in.nextLine();
        }
        
        for (int i = 0; i < Q; i++) {
            String FNAME = in.nextLine(); // One file name per line.
            String extension = FNAME.substring(FNAME.lastIndexOf('.')+1);
            System.err.println(FNAME + " " + extension);
            if(FNAME.contains(".") && typeDictionary.containsKey(extension.toLowerCase())){
                System.out.println(typeDictionary.get(extension.toLowerCase()));
            }else{
                System.out.println("UNKNOWN");
            }
        }
    }
}