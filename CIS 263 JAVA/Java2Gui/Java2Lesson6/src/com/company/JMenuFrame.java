package com.company;
import javax.swing.*;
import java.awt.*;
import java.awt.event.*;
import java.awt.Color;

public class JMenuFrame extends JFrame implements ActionListener{

    public static void main (String [] args)
    {
        JMenuFrame mFrame = new JMenuFrame();
        final int WIDTH = 250;
        final int HEIGHT = 200;
        mFrame.setSize(WIDTH, HEIGHT);
        mFrame.setVisible(true);
    }

    private JMenuBar mainbar = new JMenuBar();
    private JMenu menu1 = new JMenu("File");
    private JMenu menu2 = new JMenu("Colors");
    private JMenu bright = new JMenu("Bright");

    private JMenuItem exit = new JMenuItem("Exit");
    private JMenuItem dark = new JMenuItem("Dark");
    private JMenuItem white = new JMenuItem("White");
    private JMenuItem pink = new JMenuItem("Pink");
    private JMenuItem yellow = new JMenuItem("Yellow");

    private JLabel label = new JLabel("Hello");

    public JMenuFrame()
    {
        setLayout(new FlowLayout());
        setDefaultCloseOperation(EXIT_ON_CLOSE);
        setJMenuBar(mainbar);
        mainbar.add(menu1);
            menu1.add(exit);
            exit.addActionListener(this);
        mainbar.add(menu2);
            menu2.add(bright);
                bright.add(pink);
                pink.addActionListener(this);
                bright.add(yellow);
                yellow.addActionListener(this);
            menu2.add(dark);
            dark.addActionListener(this);
            menu2.add(white);
            white.addActionListener(this);

        add(label);
        label.setFont(new Font("Arial", Font.BOLD, 26));
    }

    @Override
    public void actionPerformed(ActionEvent e)
    {
        Object source = e.getSource();
        Container con = getContentPane();
        if (source == exit)
            System.exit(0);
        else if (source == dark)
            con.setBackground(Color.BLACK);
        else if (source == white)
            con.setBackground(Color.WHITE);
        else if (source == pink)
            con.setBackground(Color.PINK);
        else con.setBackground(Color.YELLOW);
    }

}
