package com.company;

import java.io.*;
import java.text.SimpleDateFormat;
public class FileReadWrite {

    public static void main(String[] args) {
        File myFile = new File("SomeData.txt");
        SimpleDateFormat sdf = new SimpleDateFormat("MM/dd/yyyy HH:mm:ss");
        if (myFile.exists())
        {
            System.out.println(myFile.getName() + " exists");
            System.out.println("The file is " + myFile.length() + " bytes long.");
            System.out.println("The file was last modified on " + sdf.format(myFile.lastModified()));

            if (myFile.canRead())
                System.out.println("Ok to read");
            else
                System.out.println("Not ok to read");

            if (myFile.canWrite())
                System.out.println("Ok to write");
            else
                System.out.println("Not ok to write");
        }
        else
            System.out.println("File does not exist");
    }
}
