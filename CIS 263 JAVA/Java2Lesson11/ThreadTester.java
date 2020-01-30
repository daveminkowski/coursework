/***********************************************************************************************
 Name:			    David Minkowski
 Course:			CIS 263AA - Summer 2018 - Class: 11755
 Assignment:		Lesson 11 Project
 Date:			    07/25/2018
 Description:	    This program runs 2 threads which are set to perform a println task at specific
                    times.
 ************************************************************************************************/
public class ThreadTester{

    public static void main (String[] args)
    {
        Thread threadWait1 = new Thread(new ThreadWaiterOne());
        Thread threadWait2 = new Thread(new ThreadWaiterTwo());

        threadWait1.start();
        threadWait2.start();

        try
        {
            threadWait1.join();
            threadWait2.join();
        }

        catch (InterruptedException e)
        {
            e.printStackTrace();
        }
    }
}
