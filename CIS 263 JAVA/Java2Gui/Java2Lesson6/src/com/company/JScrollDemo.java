package com.company;
import javax.swing.*;
import java.awt.*;

public class JScrollDemo extends JFrame{

    private JPanel panel = new JPanel();
    private JScrollPane scroll = new JScrollPane(panel,
            ScrollPaneConstants.VERTICAL_SCROLLBAR_ALWAYS,
            ScrollPaneConstants.HORIZONTAL_SCROLLBAR_ALWAYS);       // scroll bars always show when given the constructor arguments to do so
    private JScrollPane scroll2 = new JScrollPane(panel);           // scroll bars will only show as needed when the constructor is given no arguments

    private JLabel label = new JLabel("Four Score and Seven");
    private Font bigFont = new Font("Arial", Font.PLAIN, 20);

    private Container con;

    public JScrollDemo()
    {
        con = getContentPane();
        label.setFont(bigFont);
        con.add(scroll);
        panel.add(label);
        setDefaultCloseOperation(EXIT_ON_CLOSE);
    }

    public static void main (String[] args)
    {
        final int WIDTH = 180;
        final int HEIGHT = 100;
        JScrollDemo aFrame = new JScrollDemo();
        aFrame.setSize(WIDTH, HEIGHT);
        aFrame.setVisible(true);

    }
}
