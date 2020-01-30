/***********************************************************************************************
 Name:			    David Minkowski
 Course:			CIS 263AA - Summer 2018 - Class: 11755
 Assignment:		Lesson 11 Project
 Date:			    07/25/2018
 Description:	    This program runs 2 threads which are set to perform a println task at specific
                    times.
 ************************************************************************************************/
public class ThreadWaiterOne implements Runnable{

    @Override
    public void run()
    {
        try
        {
            Thread.sleep(20000);
            System.out.println("Thread Waiter One is done.");
        }
        catch (InterruptedException ex)
        {
            ex.printStackTrace();
        }
    }
}
