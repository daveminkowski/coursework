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
import java.net.Socket;
import java.util.Scanner;

public class MyClient {

    public static void main(String[] args) {
        MyClient myClient = new MyClient();
        try
        {
            myClient.run();
        }
        catch (IOException e)
        {
            e.printStackTrace();
        }
    }// end main

    public void run() throws IOException {

        int cost;
        String state , input;
        char choice;
        Scanner userInput = new Scanner(System.in);
        Socket clientToServerSocket = new Socket("127.0.0.1", 1342);
        Scanner serverFeedback = new Scanner(clientToServerSocket.getInputStream());

            System.out.println("This program will show your total travel costs for each of our three available vacation packages.");
            System.out.println("Would you prefer (A)rizona, (N)ew York or (U)tah? Press (Q) to quit the application.");
            System.out.println(" ");

            input = userInput.next().toLowerCase();
            choice = input.charAt(0);

            switch (choice) {
                case 'a':
                    System.out.println("Arizona. Fantastic place to hide from cold Winters.");
                    state = "Arizona";
                    passChoice(choice, clientToServerSocket);
                    break;
                case 'n':
                    System.out.println("The Big Apple. Always wanted to go there.");
                    state = "New York";
                    passChoice(choice, clientToServerSocket);
                    break;
                case 'u':
                    System.out.println("Temperate Summers make for an enjoyable outdoorsy experience.");
                    state = "Utah";
                    passChoice(choice, clientToServerSocket);
                    break;
                case 'q':
                    System.out.println("Goodbye!");
                    System.exit(0);
                default:
                    System.out.println("Invalid choice. Closing.");
                    return;
            }

            cost = serverFeedback.nextInt();
            System.out.println("The cost of your trip to " + state + " is: $" + cost);
            System.out.println(" ");
        }//end run

    public static void passChoice(char choice, Socket socket) {
        try {
            PrintStream printStream = new PrintStream(socket.getOutputStream());
            printStream.println(choice);

        } catch (IOException ex) {

        }
    } //end passChoice



} //end class
