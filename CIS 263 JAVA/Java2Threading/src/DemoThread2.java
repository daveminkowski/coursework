// implementing runnable interface to run a thread
// will output the count every half second (500 milliseconds) until it counts to 10

public class DemoThread2 implements Runnable{

    public static void main (String[] args)
    {
        Thread thread1 = new Thread(new DemoThread2());       //declare a new thread object AS a class object
        thread1.start();

    }

    @Override
    public void run()
    {
        for (int i = 0; i < 10; i++)
        {
            System.out.println("Thread ID: " + Thread.currentThread().getId() + " Count is " + i);
            try
            {
                Thread.sleep(500);
            }
            catch (InterruptedException ex)
            {
                ex.printStackTrace();
            }
        }
    }
}
