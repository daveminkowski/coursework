package com.company;

import java.io.*;

public class DemoFileClass {

    public static void main(String[] args) {
        File myFile = new File("SomeData.txt");

        // To see if this file exists, we can use the exists() method.
        if (myFile.exists())
        {
            System.out.println("Yes, the file exists and it's " + myFile.length() + " bytes long.");
            System.out.println(myFile);
        }
        else
            System.out.println("Sorry, but the file does not exist.");
    }
}
