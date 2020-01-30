import javax.swing.*;
import java.awt.*;

public class DisplayImage extends JApplet {

    private Image image;

    @Override
    public void init()
    {
        image = getImage(getDocumentBase(), getParameter("image.jpg"));
    }

    @Override
    public void paint(Graphics graphics)
    {
        graphics.drawImage(image, 100, 100, this);
    }

}

