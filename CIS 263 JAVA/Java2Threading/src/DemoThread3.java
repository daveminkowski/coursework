//creating a thread within a single main method by creating a new thread object as a runnable object
// then coding action within the run method.
// will output the count every half second (500 milliseconds) until it counts to 10

public class DemoThread3 {

    public static void main(String[] args) {

        Thread thread1 = new Thread(new Runnable() {

            @Override
            public void run() {

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
        });

        thread1.start();

    }
}
