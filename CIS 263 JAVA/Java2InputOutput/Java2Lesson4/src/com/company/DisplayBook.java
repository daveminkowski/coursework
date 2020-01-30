/***********************************************************************************************
 Name:			David Minkowski
 Course:		CIS 263AA - Summer 2018 - Class: 11755
 Assignment:	Lesson 4 Project
 Date:			06/12/2018
 Description:	This program reads the contents of a text file or creates the text file if one
                does not exist. This can be done in two ways. One, as illustrated below, is by
                creating the file object with a specific name and checking if it exists, then
                prompting the user to create it if it does not. The second way is by calling the
                read function first, then calling the write function if a FileNotFound exception
                occurs.
 ************************************************************************************************/

package com.company;
import java.io.*;
import java.util.Scanner;

public class DisplayBook {

    public static void main(String[] args) {

        String filename = "FavoriteBook2.txt";

        File myFile = new File(filename);

        if (myFile.exists()) {
            TextReader(filename);
        }
        else {
            TextWriter(filename);
        }

        // this if/else myFile.exists() block can also be accomplished by using only the call to TextReader since a call is made to TextWrite when a filenotfound exception is caught.
    }

    public static void TextReader(String filename) {

        String line;

        try
        {
            FileReader fileReader = new FileReader(filename);
            BufferedReader bufferedReader = new BufferedReader(fileReader);
            System.out.println("My favorite book is: ");
            while ((line = bufferedReader.readLine()) != null)
            {
                System.out.println("\"" + line + "\"");
            }

            bufferedReader.close();
        }

        catch (FileNotFoundException e)
        {
            TextWriter(filename); // this will only be called here if the file object is not initially created and the TextRead method is unable to find the filename given.
        }

        catch (IOException e)
        {
            System.out.println("Error reading file \"" + filename + "\"");
        }
    }

    public static void TextWriter(String filename) {

        try
        {
            FileWriter fileWriter = new FileWriter(filename);
            BufferedWriter bufferedWriter = new BufferedWriter(fileWriter);
            Scanner input = new Scanner(System.in);
            System.out.println("No file found.");
            System.out.println("Let's create one now.");
            System.out.println("What is the title of your favorite book?");
            String title = input.nextLine();

            bufferedWriter.write(title);
            bufferedWriter.close();
        }

        catch (IOException e)
        {
            System.out.println("Error writing to file \"" + filename + "\"");
        }
    }
}
