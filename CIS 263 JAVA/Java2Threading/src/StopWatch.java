/***********************************************************************************************
 Name:			    David Minkowski
 Course:			CIS 263AA - Summer 2018 - Class: 11755
 Assignment:		Lesson 11 Project
 Date:			    07/25/2018
 Description:	    This program runs 2 threads which are set to count & display seconds and
                    minutes indefinitely.
 ************************************************************************************************/
public class StopWatch{

    public static void main (String[] args)
    {
        Thread secondsThread = new Thread(new Second());
        Thread minutesThread= new Thread(new Minute());

        secondsThread.start();
        minutesThread.start();

        try
        {
            secondsThread.join();
            minutesThread.join();
        }

        catch (InterruptedException e)
        {
            e.printStackTrace();
        }
    }
}
