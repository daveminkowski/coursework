/***********************************************************************************************
 Name:			    David Minkowski
 Course:			CIS 263AA - Summer 2018 - Class: 11755
 Assignment:		Lesson 11 Project
 Date:			    07/25/2018
 Description:	    This program runs 2 threads which are set to count & display seconds and
                    minutes indefinitely.
 ************************************************************************************************/
public class Second implements Runnable{

    private static int seconds = 1;

    @Override
    public void run()
    {
        while (true) {
            try
            {
                Thread.sleep(1000);
                System.out.println("Seconds: " + (seconds));
                seconds++;
            }

            catch (InterruptedException ex)
            {
                ex.printStackTrace();
            }
        }
    }
}
