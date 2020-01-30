import javax.swing.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class ListenForEventsApplet extends JApplet {

    // this method is called before the program is displayed. This is where you will want to create a button
    public void init()
    {
        JButton button = new JButton("Submit");

        // create the action Listener
        button.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                // when the button is used, this wcode will execute
                String title = "The button was pressed";
                String message = "The applet is listening";
                JOptionPane.showMessageDialog(null, message, title, JOptionPane.INFORMATION_MESSAGE);
            }
        });

        getContentPane();
        add(button);
    }
}
