import java.awt.*;
import java.awt.event.*;
import java.awt.Color;
import javax.swing.*;

public class JPanelWithButton extends JPanel implements ActionListener{

    JButton button = new JButton("Press Me");
    Color color;
    String colorString;

    public JPanelWithButton()
    {
        color = Color.red;
        colorString = "Red";
        setBackground(color);
        add(button);
        button.addActionListener(this);
    }

    public void actionPerformed(ActionEvent event)
    {
        if (color.equals(Color.RED))
        {
            color = Color.YELLOW;
            colorString = "Yellow";
        }
        else
        {
            color = Color.red;
            colorString = "Red";
        }
        setBackground(color);
    }

    public void paintComponent(Graphics g)
    {
        super.paintComponent(g);
        g.drawString("The panel is " + colorString, 20, 80);
    }
}
