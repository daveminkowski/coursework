package com.company;
import java.util.Scanner;

public class EvenOdd {

    public static void main (String[] args) {

        Scanner input = new Scanner(System.in);
        int number;
        int number1;
        System.out.println("Enter a number:");
        number1 = input.nextInt();
        number = Math.abs(number1);

        if (isEven(number))
            System.out.println(number1 + " is even.");
        else
            System.out.println(number1 + " is odd");
    }

    public static boolean isEven(int number)
    {
        boolean result;             // or test for true here instead of false %2 == 0
        if (number % 2 == 1)
            result = false;
        else
            result = true;
        assert number % 2 == 0 : number + " % 2 is " + number % 2;
        return result;
    }
}
