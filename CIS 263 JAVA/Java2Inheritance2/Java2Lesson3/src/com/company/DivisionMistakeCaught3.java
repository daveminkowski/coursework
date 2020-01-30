package com.company;
import java.util.*;

public class DivisionMistakeCaught3 {

    public static void main (String[] args){

        Scanner input = new Scanner(System.in);
        int numerator, denominator, result;
        try
        {
            System.out.println("Enter numerator >> ");
            numerator = input.nextInt();
            System.out.println("Enter denominator >> ");
            denominator = input.nextInt();
            result = numerator / denominator;
            System.out.println(numerator + " / " + denominator + " = " + result);
        }
        catch(Exception mistake)
        {
            System.out.println("Operation Unsuccessful");
        }
        System.out.println("End of program");
    }
}
