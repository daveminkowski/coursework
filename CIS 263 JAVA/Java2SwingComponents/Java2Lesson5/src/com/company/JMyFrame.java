package com.company;
import javax.swing.*;
import java.awt.*;

public class JMyFrame extends JFrame {

    final int WIDTH = 300;
    final int HEIGHT = 150;

    public JMyFrame()
    {
        super("Demonstrating many components");
        setSize(WIDTH, HEIGHT);
        setDefaultCloseOperation(EXIT_ON_CLOSE);

        JLabel heading = new JLabel("This frame has many components");
        heading.setFont(new Font("Arial", Font.BOLD, 16));

        JLabel namePrompt = new JLabel("Enter your name:");
        JTextField nameField = new JTextField(12);

        JButton button = new JButton("Click to continue");

        setLayout(new FlowLayout());

        add(heading);
        add(namePrompt);
        add(nameField);
        add(button);

        nameField.setText(button.getText());
    }


}
