import javax.swing.*;

public class JDemoFontPanel extends JFrame{

    JFontPanel p1 = new JFontPanel();

    public JDemoFontPanel()
    {
        setDefaultCloseOperation(EXIT_ON_CLOSE);
        add(p1);
    }

    public static void main(String[] args) {

        JDemoFontPanel frame = new JDemoFontPanel();
        frame.setSize(200, 200);
        frame.setVisible(true);

    }
}
