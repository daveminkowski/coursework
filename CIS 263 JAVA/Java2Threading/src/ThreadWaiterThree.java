public class ThreadWaiterThree implements Runnable{

    @Override
    public void run()
    {
        for (int i = 0; i < 20; i++)
        {

            try {
                Thread.sleep(1000);
                System.out.println((i + 1));
            } catch (InterruptedException ex) {
                ex.printStackTrace();
            }
        }
    }
}
