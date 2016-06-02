import java.util.*;
import java.io.*;
import java.math.*;

class Solution {

    public static void main(String args[]) {
        Scanner in = new Scanner(System.in);
        String LON = in.next();
        String LAT = in.next();
        int N = in.nextInt();
        in.nextLine();
        
        double myLongitude = Double.parseDouble(LON.replace(',','.')) * (Math.PI/180.0);
        double myLatitude = Double.parseDouble(LAT.replace(',','.')) * (Math.PI/180.0);
        
        List<Defibrillator> defibList = new ArrayList<Defibrillator>();
        for (int i = 0; i < N; i++) {
            String DEFIB = in.nextLine();
            defibList.add(new Defibrillator(DEFIB));
        }
        
        double minimalDistance = 9999.99, x, y, distance;
        String defibName = "";
        for(Defibrillator d: defibList){
            x = (d.getLongitude() - myLongitude) * Math.cos((myLatitude + d.getLatitude())/2);
            y = (d.getLatitude() - myLatitude);
            distance = Math.sqrt(x*x + y*y);
            
            if(distance < minimalDistance){
                minimalDistance = distance;
                defibName = d.getName();
            }
        }
        
        System.out.println(defibName);
    }
}

class Defibrillator{
    String name;
    double latitude, longitude;
    
    public Defibrillator(String defibData){
        String[] tokens = defibData.split(";");
        name = tokens[1];
        longitude = Double.parseDouble(tokens[4].replace(',','.')) * (Math.PI/180.0); //Radian conversion
        latitude = Double.parseDouble(tokens[5].replace(',','.')) * (Math.PI/180.0);
    }
    
    public String getName(){
        return name;
    }
    
    public double getLatitude(){
        return latitude;
    }
    
    public double getLongitude(){
        return longitude;
    }
}