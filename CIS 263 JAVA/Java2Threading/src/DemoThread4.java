// joining threads, pausing thread progress, incrementing a synchronized counter.

public class DemoThread4 {

    private static int count = 0;

    public static synchronized void incrementCount()    // each count++ may be accessed one at a time instead of simultaneously,
    {                                                   //  allowing the count to actually reach 20000. Synchronize locks the method to all
        count++;                                        // but one thread at a time.
    }
    public static void main (String[] args)
    {
        Thread thread1 = new Thread(new Runnable() {
            @Override
            public void run() {
                for (int i = 0; i < 10000; i++)
                {
                    incrementCount();
                }
            }
        });

        Thread thread2 = new Thread(new Runnable() {
            @Override
            public void run() {
                for (int i = 0; i < 10000; i++)
                {
                    incrementCount();
                }
            }
        });

        thread1.start(); // returns immediately after thread1 is started. Thread is started at the same time the count is displayed in line 39....
        thread2.start();

        try {
            thread1.join();                     // .. but when the threads are JOINED. joining threads pauses current thread execution
            thread2.join();                     // unless the specified thread is dead.
        } catch (InterruptedException e) {
            e.printStackTrace();
        }

        System.out.println("value: " + count);

    }
}
