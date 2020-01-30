import javax.swing.*;
import java.awt.*;

public class JDemoPanelWithButton extends JFrame{

    JPanelWithButton p1 = new JPanelWithButton();

    public JDemoPanelWithButton()
    {
        add(p1, BorderLayout.CENTER);
        setDefaultCloseOperation(EXIT_ON_CLOSE);
    }

    public static void main (String[] args)
    {
        JDemoPanelWithButton frame = new JDemoPanelWithButton();
        frame.setSize(200, 200);
        frame.setVisible(true);
    }
}
