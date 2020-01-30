/***********************************************************************************************
 Name:			David Minkowski
 Course:		CIS 263AA - Summer 2018 - Class: 11755
 Assignment:	Lesson 4 Project
 Date:			06/12/2018
 Description:	This program checks if a file exists then displays its name and size. A second
                method here will compare the size of the two files and display their size ratio.
                Decimal numbers are rounded to the nearest tenths place for division, and then
                rounded to the nearest whole number for the simpler explanation of the ratio.
 ************************************************************************************************/

package com.company;
import java.io.*;
import java.text.DecimalFormat;
import java.text.NumberFormat;

public class FileStatistics2 {

    public static void main(String[] args) {

        String[] filenames = new String[]{"MovieQuote.txt", "MovieQuote.docx"};

        for (int x = 0; x < filenames.length; ++x)
        {
            FileStatus(filenames[x]);
        }

        FileSizeRatio(filenames[0], filenames[1]);
    }

    public static void FileStatus (String filename)
    {
        File myFile = new File(filename);
        if (myFile.exists())
        {
            System.out.println("The file name is " + myFile.getName());
            System.out.println("The file is " + myFile.length() + " bytes.");
        }
        else
            System.out.println(myFile.getName() + " does not exist");

        System.out.println(" ");
    }

    public static void FileSizeRatio(String textFile, String wordDocFile)
    {
        File myFile1 = new File(textFile);
        File myFile2 = new File(wordDocFile);

        double textFileSize = myFile1.length();
        double docFileSize = myFile2.length();

        NumberFormat numForm = new DecimalFormat("#0.0");
        NumberFormat roundedWhole = new DecimalFormat("#0");

        double fileRatio = docFileSize / textFileSize;
        System.out.println("The size ratio of the MSWord Document \"" + wordDocFile + "\" when compared to the size of the text file \"" + textFile + "\" is "  + numForm.format(fileRatio) + " : 1, ");
        System.out.println("so the .docx file is about " + roundedWhole.format(fileRatio) + " times larger than the .txt file.");
        System.out.println(" ");
    }
}
