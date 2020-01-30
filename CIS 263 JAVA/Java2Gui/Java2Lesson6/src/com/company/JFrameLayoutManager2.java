package com.company;

import java.awt.*;
import javax.swing.*;

public class JFrameLayoutManager2 {

    public static void main (String [] args) {


        final int WIDTH = 500; // constants for size
        final int HEIGHT = 250;

        JFrame aFrame = new JFrame("Layout Manager1");
        aFrame.setSize(WIDTH, HEIGHT);
        aFrame.setVisible(true);
        aFrame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);

        JLabel greeting = new JLabel("Hello");
        JLabel greeting2 = new JLabel("Who are you?");

        aFrame.add(greeting);
        aFrame.add(greeting2);

        // below is the flow layout syntax

        FlowLayout flow = new FlowLayout();     // you can combine
        aFrame.setLayout(flow);                 // these two statements

        // aFrame.setLayout(new FlowLayout());     // into this single one if you don't need to name this layout


    }
}
