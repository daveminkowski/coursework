package com.company;
import javax.swing.*;

public class Call {

    public static void main(String[] args) {
        // array of contacts
        Person[] phoneContacts = new Person[4];

        phoneContacts[0] = new Person("Joe", "555-1234");
        phoneContacts[1] = new Person("Bob", "555-4444");
        phoneContacts[2] = new Person("Alice", "555-6565");
        phoneContacts[3] = new Person("Sally", "555-1111");

        // array of phone models
        Phone[] phoneArray = new Phone[2];
        phoneArray[0] = new iPhone();
        phoneArray[1] = new Samsung();

        // variables for choosing contacts and phone type
        int contact;
        int phoneType;

        String contactEntry = JOptionPane.showInputDialog(null,"Select a contact to call: \n" +
                "1 - Joe\n" +
                "2 - Bob\n" +
                "3 - Alice\n" +
                "4 - Sally");

        contact = Integer.parseInt(contactEntry); // choose 1 through 4

        String numberEntry = JOptionPane.showInputDialog(null,"Select your phone type: \n" +
                "1 - iPhone\n" +
                "2 - Samsung");

        phoneType = Integer.parseInt(numberEntry); // choose 1 or 2

        if (phoneType == 1) {
            phoneArray[0].call(phoneContacts[contact - 1]); // if phoneType is iPhone, call contact (value - 1 to account for array element 0) on iPhone
        }

        else {
            phoneArray[1].call(phoneContacts[contact - 1]); // if phoneType is Samsung, call contact (value - 1 to account for array element 0) on Samsung
        }
    }

}
