/***********************************************************************************************
 Name:			David Minkowski
 Course:		CIS 263AA - Summer 2018 - Class: 11755
 Assignment:	Lesson 4 Project
 Date:			06/12/2018
 Description:	This program checks if a file exists then displays its name, size and last modified
                date. If the file does not exist, the console will notify the user of such.
                (Lesson 5.txt is not included and will cause such a notification)
 ************************************************************************************************/

package com.company;

import java.io.*;
import java.text.SimpleDateFormat;
public class FileStatistics {

    public static void FileStatus (String filename)
    {
        File myFile = new File(filename);
        SimpleDateFormat sdf = new SimpleDateFormat("MM/dd/yyyy HH:mm:ss");

        if (myFile.exists())
        {
            System.out.println("The file name is " + myFile.getName());
            System.out.println("The file is " + myFile.length() + " bytes.");
            System.out.println("The file was last modified on " + sdf.format(myFile.lastModified()));
        }
        else
            System.out.println(myFile.getName() + " does not exist");

        System.out.println(" ");
    }


    public static void main(String[] args) {

        String[] filenames = new String[]{"Lesson4File.txt", "Lesson5File.txt"}; // lesson5File.txt does not exist

        for (int x = 0; x < filenames.length; ++x)
        {
            FileStatus(filenames[x]);
        }
    }
}
