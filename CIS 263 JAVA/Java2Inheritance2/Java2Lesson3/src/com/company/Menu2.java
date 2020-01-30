package com.company;
import javax.swing.*;

public class Menu2 { // returns an entree choice for the menu item

    protected String[] entreeChoice = {"Rosemary Chicken", "Beef Wellington", "Maine Lobster"};

    private String menu = "";
    private int choice;
    protected char initial[] = new char[entreeChoice.length];            // NEW

    public String displayMenu() throws MenuException
    {
        for (int x = 0; x < entreeChoice.length; ++x)
        {
            menu = menu + "\n" + (x+1) + " for " + entreeChoice[x];
            initial[x] = entreeChoice[x].charAt(0);                     // NEW
        }
        String input = JOptionPane.showInputDialog(null, "Type your selection, then press enter." + menu);

        for (int y = 0; y < entreeChoice.length; ++y)
            if (input.charAt(0) == initial[y])                          // NEW
                throw (new MenuException(entreeChoice[y]));             // NEW

        choice = Integer.parseInt(input);
        return(entreeChoice[choice - 1]);
    }
}
