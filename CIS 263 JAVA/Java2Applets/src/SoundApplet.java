import javafx.scene.media.AudioClip;

import javax.swing.*;

public class SoundApplet extends JApplet {

    public void init()
    {
        super.init();
        resize(0,0);
        // load the sound that will be played in applet

        java.applet.AudioClip knocking = getAudioClip(getDocumentBase(), "mrt.wav");
        knocking.play();
    }
}
