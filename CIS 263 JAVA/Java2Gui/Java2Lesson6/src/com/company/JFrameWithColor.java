package com.company;
import java.awt.*;
import javax.swing.*;
import java.awt.Color;


public class JFrameWithColor extends JFrame {

    private final int SIZE = 200;
    private Container con = getContentPane();
    private JButton button = new JButton("Press Me");

    public JFrameWithColor()
    {
        setSize(SIZE, SIZE);
        con.setLayout(new FlowLayout());
        con.add(button);
        con.setBackground(Color.yellow);
        button.setBackground(Color.red);
        button.setForeground(Color.white);
    }

    public static void main (String[] args) {

        JFrameWithColor frame = new JFrameWithColor();
        frame.setVisible(true);
    }

}
