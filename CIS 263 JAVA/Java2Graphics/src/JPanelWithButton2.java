import javax.swing.*;
import java.awt.*;
import java.awt.event.*;

public class JPanelWithButton2 extends JPanel implements ActionListener{

    int count = 0;

    JButton button = new JButton("Press Me");
    JLabel label = new JLabel("No Count Yet");


    public JPanelWithButton2()
    {
        add(button);
        add(label);
        button.addActionListener(this);
    }

    public void actionPerformed(ActionEvent event) {
        ++count;
        label.setText("The count is " + count);
        repaint();
    }

    @Override
    public void paintComponent(Graphics g) {
        super.paintComponent(g);
        g.drawString("The count is " + count, 20, 80);
    }
}
