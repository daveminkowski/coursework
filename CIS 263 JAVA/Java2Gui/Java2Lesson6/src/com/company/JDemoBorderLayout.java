package com.company;
import javax.swing.*;
import java.awt.*;

public class JDemoBorderLayout extends JFrame{

    private JButton nb = new JButton("North Button");
    private JButton sb = new JButton("South Button");
    private JButton eb = new JButton("East Button");
    private JButton wb = new JButton("West Button");
    private JButton cb = new JButton("Center Button");

    private Container con = getContentPane();

    public JDemoBorderLayout()
    {
        //con.setLayout(new BorderLayout()); optional call, borderlayout is default
        con.add(nb, BorderLayout.NORTH);
        con.add(sb, BorderLayout.SOUTH);
        con.add(eb, BorderLayout.EAST);
        con.add(wb, BorderLayout.WEST);
        con.add(cb, BorderLayout.CENTER);
        setSize(400, 200);
    }

    public static void main (String[] args) {

        JDemoBorderLayout frame = new JDemoBorderLayout();
        frame.setVisible(true);
    }


}
