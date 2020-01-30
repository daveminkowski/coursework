package com.company;
import javax.swing.*;

public class CreateJFrameWithComponents {

    public static void main (String [] args) {

        JFrameWithComponents aFrame = new JFrameWithComponents();
        final int WIDTH = 350;
        final int HEIGHT = 200;

        aFrame.setSize(WIDTH, HEIGHT);
        aFrame.setVisible(true);
    }
}
