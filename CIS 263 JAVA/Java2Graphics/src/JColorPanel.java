import java.awt.*;
import java.awt.event.*;
import java.awt.Color;
import javax.swing.*;

public class JColorPanel extends JPanel {

    int count = 0;
    String colorString;

    public JColorPanel (Color color)
    {
        if (color.equals(Color.RED))
            colorString = "Red";
        else
            colorString = "Blue";
        setBackground(color);
    }

    @Override
    public void paintComponent(Graphics g)
    {
        super.paintComponent(g);
        ++count;
        System.out.println("In paintComponent() method -- " + colorString + " " + count);
    }

}
