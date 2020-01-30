package com.company;
import javax.swing.*;

public class TestPerson {

    public static void main (String[] args) {

        Person[] phoneContacts = new Person[3];
        int x;

        for (x = 0; x < phoneContacts.length; x++)
        {
            phoneContacts[x] = new Person();
        }

        StringBuffer outString = new StringBuffer();
        for (x = 0; x < phoneContacts.length; x++)
        {
            outString.append("\n");
            outString.append(phoneContacts[x].toString());
        }

        JOptionPane.showMessageDialog(null, outString);
    }
}
