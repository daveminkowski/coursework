/***********************************************************************************************
 Name:			    David Minkowski
 Course:			CIS 263AA - Summer 2018 - Class: 11755
 Assignment:		Lesson 11 Project
 Date:			    07/25/2018
 Description:	    This program runs 2 threads which are set to count & display seconds and
                    minutes indefinitely.
 ************************************************************************************************/
public class Minute implements Runnable{

    private static int minutes = 1;

    @Override
    public void run()
    {
        while (true) {
            try
            {
                Thread.sleep(60000);
                System.out.println("MINUTES: " + minutes);
                minutes++;
            }

            catch (InterruptedException ex)
            {
                ex.printStackTrace();
            }
        }
    }
}
