/***********************************************************************************************
 Name:			David Minkowski
 Course:		CIS 263AA - Summer 2018 - Class: 11755
 Assignment:    Lesson 5 Project
 Date:			06/21/2018
 Description:	This program allows a user to make several selections from checkboxes added to
                a JFrame. This would work a lot better if I could figure out how to center the
                text in this layout :)
 ************************************************************************************************/

package com.company;
import javax.swing.*;
import java.awt.*;
import java.awt.event.*;

public class BobBurger extends JFrame implements ItemListener {

    final int BURGER_PRICE = 5;
    final int DOUBLE_BURGER_PRICE = 7;

    final int WIDTH = 120;
    final int HEIGHT = 400;

    Font bigFont = new Font("Arial", Font.BOLD, 18);
    Font medFont = new Font("Arial", Font.PLAIN, 14);

    int totalPrice = 0;

    JCheckBox burgerBox = new JCheckBox("Single Patty: $" + BURGER_PRICE, false);
    JCheckBox dblBurgerBox = new JCheckBox("Double Patty: $" + DOUBLE_BURGER_PRICE, false);

    JCheckBox smDrinkBox = new JCheckBox("Small Drink", false);
    JCheckBox medDrinkBox = new JCheckBox("Medium Drink", false);
    JCheckBox lgDrinkBox = new JCheckBox("Large Drink", false);

    JCheckBox lettuceBox = new JCheckBox("Lettuce", false);
    JCheckBox cheeseBox = new JCheckBox("Cheese", false);
    JCheckBox pickleBox = new JCheckBox("Pickles", false);

    ButtonGroup burgerGroup = new ButtonGroup();
    ButtonGroup drinkGroup = new ButtonGroup();
    ButtonGroup toppingsGroup = new ButtonGroup();

    JLabel burgerLabel = new JLabel("Burger Menu");
    JLabel toppingLabel = new JLabel("Toppings");
    JLabel drinkLabel = new JLabel("Drinks");
    JLabel priceLabel = new JLabel("Total: ");

    JTextField totPrice = new JTextField(5);

    public BobBurger()
    {
        super("Bob's Burgers");
        setDefaultCloseOperation(EXIT_ON_CLOSE);
        setSize(WIDTH, HEIGHT);
        setLayout(new FlowLayout(FlowLayout.CENTER));

        burgerGroup.add(burgerBox);
        burgerGroup.add(dblBurgerBox);

        drinkGroup.add(smDrinkBox);
        drinkGroup.add(medDrinkBox);
        drinkGroup.add(lgDrinkBox);

        toppingsGroup.add(lettuceBox);
        toppingsGroup.add(cheeseBox);
        toppingsGroup.add(pickleBox);

        burgerLabel.setFont(bigFont);
        burgerLabel.setHorizontalAlignment(JLabel.CENTER);
        add(burgerLabel);

        add(burgerBox);
        add(dblBurgerBox);

        toppingLabel.setFont(bigFont);
        toppingLabel.setHorizontalAlignment(JLabel.CENTER);
        add(toppingLabel);

        add(lettuceBox);
        add(cheeseBox);
        add(pickleBox);

        drinkLabel.setFont(bigFont);
        drinkLabel.setHorizontalAlignment(JLabel.CENTER);
        add(drinkLabel);

        add(smDrinkBox);
        add(medDrinkBox);
        add(lgDrinkBox);

        add(priceLabel);
        priceLabel.setFont(medFont);
        add(totPrice);

        totPrice.setFont(medFont);
        totPrice.setText("$ " + totalPrice);

        burgerBox.addItemListener(this);
        dblBurgerBox.addItemListener(this);
    }

    @Override
    public void itemStateChanged(ItemEvent event)
    {
        Object source = event.getSource();
        int select = event.getStateChange();

        if (source == burgerBox)

            if (select == ItemEvent.SELECTED)
                totalPrice += BURGER_PRICE;
            else
                totalPrice -= BURGER_PRICE;

        else if (source == dblBurgerBox)
        {
            if (select == ItemEvent.SELECTED)
                totalPrice += DOUBLE_BURGER_PRICE;
            else
                totalPrice -= DOUBLE_BURGER_PRICE;
        }

        totPrice.setText("$" + totalPrice);
    }

    public static void main (String [] args) {

        BobBurger burgerFrame = new BobBurger();
        burgerFrame.setVisible(true);

    }
}
