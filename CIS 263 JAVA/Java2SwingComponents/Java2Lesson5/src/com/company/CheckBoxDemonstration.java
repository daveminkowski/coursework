package com.company;
import javax.swing.*;
import java.awt.*;
import java.awt.event.*;

public class CheckBoxDemonstration extends JFrame implements ItemListener {

    FlowLayout flow = new FlowLayout();
    JLabel label = new JLabel("What would you like to drink?");
    JCheckBox coffee = new JCheckBox("Coffee", false);
    JCheckBox cola = new JCheckBox("Cola", false);
    JCheckBox milk = new JCheckBox("Milk", false);
    JCheckBox water = new JCheckBox("Water", false);

    JCheckBox coffee2 = new JCheckBox("Coffee", false);
    JCheckBox cola2 = new JCheckBox("Cola", false);
    JCheckBox milk2 = new JCheckBox("Milk", false);
    JCheckBox water2 = new JCheckBox("Water", false);

    ButtonGroup btnGroup = new ButtonGroup();

    Font bigArial = new Font("Arial", Font.ITALIC, 22);

    public CheckBoxDemonstration()

    {
        super("CheckBox Demonstration");
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        setLayout(flow);
        label.setFont(bigArial);

        coffee.addItemListener(this);
        cola.addItemListener(this);
        milk.addItemListener(this);
        water.addItemListener(this);

        coffee2.addItemListener(this);
        cola2.addItemListener(this);
        milk2.addItemListener(this);
        water2.addItemListener(this);

        btnGroup.add(coffee2);
        btnGroup.add(cola2);
        btnGroup.add(milk2);
        btnGroup.add(water2);

        add(label);
        add(coffee);
        add(cola);
        add(milk);
        add(water);
        add(coffee2);
        add(cola2);
        add(milk2);
        add(water2);
    }

    @Override

    public void itemStateChanged(ItemEvent event)
    {
        // actions based on choice go here
        Object source = event.getItem();
        if (source == coffee)
        {
            int select = event.getStateChange();
            if (select == ItemEvent.SELECTED) {
                // statements execute when the coffee checkbox is checked
            }
            else {
                // statements execute when coffee checkbox is unchecked
            }
        }
        else
        {
            // statements that execute when the source of the event is
            // some component other than the checkBox object
        }
    }

    public static void main (String [] args) {

        final int FRAME_WIDTH = 320;
        final int FRAME_HEIGHT = 150;

        CheckBoxDemonstration frame =  new CheckBoxDemonstration();
        frame.setSize(FRAME_WIDTH, FRAME_HEIGHT);
        frame.setVisible(true);

    } // end main
} // end class
