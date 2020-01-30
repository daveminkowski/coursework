package com.company;
import javax.swing.*;
import java.awt.*;

public class CreateTwoJMyFrameObjects {

    public static void main (String [] args) {

        JMyFrame myFirstFrame = new JMyFrame();
        JMyFrame mySecondFrame = new JMyFrame();

        myFirstFrame.setVisible(true);

        mySecondFrame.setDefaultCloseOperation(WindowConstants.DISPOSE_ON_CLOSE); // will not exit program when closed
    }
}
