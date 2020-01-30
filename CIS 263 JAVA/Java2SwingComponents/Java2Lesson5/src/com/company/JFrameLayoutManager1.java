package com.company;

import java.awt.*;
import javax.swing.*;

public class JFrameLayoutManager1 {

    public static void main (String [] args) {


        final int WIDTH = 500; // constants for size
        final int HEIGHT = 250;

        JFrame aFrame = new JFrame("Layout Manager1");
        aFrame.setSize(WIDTH, HEIGHT);
        aFrame.setVisible(true);
        aFrame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);

        JLabel greeting = new JLabel("Hello");
        JLabel greeting2 = new JLabel("Who are you?");

        aFrame.add(greeting);           // these will obscure each other without choosing a new layout
        aFrame.add(greeting2);          // default java layout is border layout
                                        // the only visible JLabel will be the last JLabel added

    }
}
