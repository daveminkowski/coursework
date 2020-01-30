//created by Dave Minkowski on 11/29/2016

import java.util.Scanner;
import java.io.File;
import java.io.FileNotFoundException;

public class GameScores {

    public static void main(String[] args)
    {
         int highNumber = 0;

        String filename = "scores.txt";
        Scanner inputFile = null;
        try
        {
            inputFile = new Scanner(new File(filename));
        }

        catch(FileNotFoundException e)
        {
            System.out.println("Error opening the file: " +filename);
            System.exit(0);
        }

        while (inputFile.hasNextInt())
                {
                    int newNumber = inputFile.nextInt();
                    if (newNumber > highNumber)
                        highNumber = newNumber;
                }

        inputFile.close();

        System.out.println("The highest score in this list of scores is " +highNumber+ "." );


    }
}
