/***********************************************************************************************
 Name:			    David Minkowski
 Course:			CIS 263AA - Summer 2018 - Class: 11755
 Assignment:		Lesson 8 Project - Triangle
 Date:			    07/22/2018
 Description:	    This program draws a triangle and adds a button which, when pressed, will flip
                    the triangle upside down (mimicking a 180 degree rotation from center)
 ************************************************************************************************/
import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.geom.GeneralPath;



public class Triangle extends JPanel implements ActionListener{


    JButton flipButton = new JButton("Flip");
    Color backgroundColor = Color.black;
    Color shapeColor = Color.yellow;
    Font bigFont = new Font("Arial", Font.BOLD, 32);

    int flipY1 = 100;
    int flipY2 = 300;

    @Override
    public void paintComponent(Graphics g)
    {
        super.paintComponent(g);
        Graphics2D gr2D = (Graphics2D)g;
        GeneralPath triangle = new GeneralPath();
        triangle.moveTo(90F, flipY2);
        triangle.lineTo(190F,flipY1);
        triangle.lineTo(290F, flipY2);
        triangle.closePath();
        g.setColor(shapeColor);
        gr2D.fill(triangle);
    }

    public Triangle()
    {   setBackground(backgroundColor);
        setLayout(new BorderLayout());
        add(flipButton, BorderLayout.NORTH);
        flipButton.setFont(bigFont);
        flipButton.setBackground(Color.darkGray);
        flipButton.setForeground(shapeColor);
        flipButton.addActionListener(this);
    }

    public static void main (String[] args)
    {
        JFrame frame = new JFrame();
        frame.setTitle("Lesson 8 Project - Flippin' Triangle");
        frame.add(new Triangle());
        frame.setSize(400, 400);
        frame.setVisible(true);
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    }

    public void actionPerformed(ActionEvent event)
    {
        if (shapeColor.equals(Color.YELLOW))
        {
            shapeColor = Color.green;
            flipButton.setForeground(shapeColor);
            flipY1 = 300;
            flipY2 = 100;
            repaint();
        }
        else
        {
            shapeColor = Color.yellow;
            flipButton.setForeground(shapeColor);
            flipY1 = 100;
            flipY2 = 300;
            repaint();
        }
    }
}
