/***********************************************************************************************
 Name:			    David Minkowski
 Course:			CIS 263AA - Summer 2018 - Class: 11755
 Assignment:		Lesson 9 Project
 Date:			    07/16/2018
 Description:	    This applet has 2 buttons which will stop and start a stopwatch. When the
                    stop button is pressed, Mr. T. discusses whether he thinks I'll figure out
                    how to properly work with timers and/or threads before this assignment's due date.
 ************************************************************************************************/

import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import javax.swing.JApplet;
import java.util.TimerTask;
import java.util.Timer;

public class StopWatch extends JApplet{

    int count = 0;
    int delay = 0;
    int period = 1000;
    static Timer timer;

    JButton buttonStartCount = new JButton("Start");
    JButton buttonStop = new JButton("Stop");
    JLabel status = new JLabel("---", SwingConstants.CENTER);

    public void init()
    {
        setSize(300, 200);
        setLayout(new GridLayout(3, 3, 5, 8));
        Font bigFont = new Font("Arial", Font.BOLD, 30);
        add(buttonStartCount);
        buttonStartCount.setFont(bigFont);

        add(buttonStop);
        buttonStop.setFont(bigFont);
        buttonStop.setEnabled(false);


        add(status);
        status.setFont(bigFont);

        buttonStartCount.addActionListener(new ActionListener()
        {
            @Override
            public void actionPerformed(ActionEvent e)
            {
                startTimer();
                buttonStartCount.setEnabled(false);
                buttonStop.setEnabled(true);
            }
        });

        buttonStop.addActionListener(new ActionListener()
        {
            @Override
            public void actionPerformed(ActionEvent e)
            {
                cancelTimer();
                java.applet.AudioClip mrt = getAudioClip(getDocumentBase(), "mrt.wav");
                mrt.play();
                status.setText("---");
                buttonStartCount.setEnabled(true);
            }
        });
    }

    public void startTimer()
    {
        timer = new Timer();
        timer.scheduleAtFixedRate(new TimerTask() {
            public void run() {
                count++;
                String time = Integer.toString(count);
                status.setText(time);
            }
        }, delay, period);
    }

    public void cancelTimer()
    {
        count = 0;
        timer.cancel();
    }
}

