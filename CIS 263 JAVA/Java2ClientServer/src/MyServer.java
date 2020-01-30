/***********************************************************************************************
 Name:			    David Minkowski
 Course:			CIS 263AA - Summer 2018 - Class: 11755
 Assignment:		Lesson 10 Project
 Date:			    07/23/2018
 Description:	    This program accepts input from a client, sends it to a server, which then
                    responds to a particular input.
 ************************************************************************************************/

import java.io.IOException;
import java.io.PrintStream;
import java.net.InetAddress;
import java.net.ServerSocket;
import java.net.Socket;
import java.util.Scanner;

public class MyServer {

    private ServerSocket serverSocket;

    public static void main(String[] args) throws IOException {
        MyServer myServer = new MyServer();
        myServer.run();
    }// end main

    public MyServer() {
        try
        {
            this.serverSocket = new ServerSocket(1342, 0, InetAddress.getByName("localhost"));
        }
        catch (IOException e)
        {
            e.printStackTrace();
        }
    }// end constructor

    public void run() {
        System.out.println("Server is alive. Launch Client.");
        Socket serverToClientSocket = null;

        while (true){
            try {
                int cost;
                String input;
                char choice;
                serverToClientSocket = serverSocket.accept();

                Scanner clientInput = new Scanner(serverToClientSocket.getInputStream());
                input = clientInput.next().toLowerCase();
                choice = input.charAt(0);

                if (choice == 'a') {
                    cost = 500;
                    passResult(cost, serverToClientSocket);
                } else if (choice == 'n') {
                    cost = 600;
                    passResult(cost, serverToClientSocket);
                } else if (choice == 'u') {
                    cost = 300;
                    passResult(cost, serverToClientSocket);
                }
            }
            catch (IOException ex)
            {
                System.out.println(ex.getMessage());
            }
            finally
            {
                try
                {
                    serverToClientSocket.close();
                }
                catch (IOException e)
                {
                    e.printStackTrace();
                }
            }
        }
    } // end run

    public static void passResult(int cost, Socket socket)
    {
        try
        {
            PrintStream printStream = new PrintStream(socket.getOutputStream());
            printStream.println(cost);
        }
        catch (IOException ex)
        {

        }

    }// end passResult

}// end class

