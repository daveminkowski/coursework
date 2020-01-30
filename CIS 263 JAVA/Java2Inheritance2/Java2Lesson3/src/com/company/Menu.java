package com.company;
import javax.swing.*;

public class Menu { // returns an entree choice for the menu item

    protected String[] entreeChoice = {"Rosemary Chicken", "Beef Wellington", "Maine Lobster"};

    private String menu = "";
    private int choice;

    public String displayMenu()
    {
        for (int x = 0; x < entreeChoice.length; ++x)
        {
            menu = menu + "\n" + (x+1) + " for " + entreeChoice[x];
        }
        String input = JOptionPane.showInputDialog(null, "Type your selection, then press enter." + menu);
        choice = Integer.parseInt(input);
        return(entreeChoice[choice - 1]);
    }
}
