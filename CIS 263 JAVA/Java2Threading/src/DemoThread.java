// extending thread class to start a thread
// will output the count every half second (500 milliseconds) until it counts to 10

public class DemoThread extends Thread{

    public static void main(String[] args) {

        DemoThread thread1 = new DemoThread();      // declare a new class object, which IS a thread object
        thread1.start();
    }


    @Override
    public void run() {

        for (int i = 0; i < 10; i++)
        {
            System.out.println("Thread ID: " + Thread.currentThread().getId() + " Count is " + (i+1));
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
