package com.company;
import javax.swing.*;
import java.awt.*;
import java.awt.event.*;
import java.awt.Color;

public class JMenuFrame2 extends JFrame
{
    private JMenuBar mainbar = new JMenuBar();

    private JMenu menu1 = new JMenu ("File");
    private JCheckBoxMenuItem check1 = new JCheckBoxMenuItem("Check Box A");
    private JCheckBoxMenuItem check2 = new JCheckBoxMenuItem("Check Box B");
    private JRadioButtonMenuItem radio1 = new JRadioButtonMenuItem("Radio Option 1");
    private JRadioButtonMenuItem radio2 = new JRadioButtonMenuItem("Radio Option 2");
    private JRadioButtonMenuItem radio3 = new JRadioButtonMenuItem("Radio Option 3");

    private ButtonGroup group = new ButtonGroup();

    public JMenuFrame2()
    {
        setLayout(new FlowLayout());
        setJMenuBar(mainbar);
        mainbar.add(menu1);
        menu1.setMnemonic('F');
        menu1.add(check1);
        menu1.add(check2);
        menu1.addSeparator();
        menu1.add(radio1);
        menu1.add(radio2);
        menu1.add(radio3);

        group.add(radio1);
        group.add(radio2);
        group.add(radio3);

        setDefaultCloseOperation(EXIT_ON_CLOSE);
    }

    public static void main (String args[])
    {
        JMenuFrame2 frame = new JMenuFrame2();
        final int WIDTH = 150;
        final int HEIGHT = 200;
        frame.setSize(WIDTH, HEIGHT);
        frame.setVisible(true);
    }
}
