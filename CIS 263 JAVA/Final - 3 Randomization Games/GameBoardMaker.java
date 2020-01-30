import javax.swing.*;
import java.awt.*;

/***********************************************************************************************
 Name:		    David Minkowski
 Course:		CIS 263AA - Summer 2018 - Class: 11755
 Assignment:    Final Project 1
 Date:			08/02/2018
 Description:	This GameBoardMaker will serve as a base class for the other games in the final
                project to inherit from, hopefully allowing me to use some of the same fields and
                panes in multiple games. This is more for me to practice a bit more with
                inheritance features and gui components. As a result, some of the objects are not
                used in all projects. I may scrap this class entirely if my projects cannot be
                similarly sized or if they require more uniquely outfitted parameters per project.
 ************************************************************************************************/

public class GameBoardMaker extends JFrame {

    final int WIDTH = 600;
    final int HEIGHT = 600;
    final int WIDE_WIDTH = 900;
    final int WIDE_HEIGHT = 460;
    final String aboutString = ("Dave Minkowski - CIS263AA - Class # 11755 - MEID: DAV2215217");

    Font hugeFont = new Font ("Arial", Font.BOLD, 42);
    Font bigFont = new Font ("Arial", Font.BOLD, 24);
    Font mediumFont = new Font ("Arial", Font.BOLD, 16);

    JMenuBar mainBar = new JMenuBar();
    JMenu fileMenu = new JMenu("File");
    JMenuItem aboutLink = new JMenuItem("About");
    JMenuItem resetLink = new JMenuItem("Reset Game");
    JMenuItem exitLink = new JMenuItem("Quit Game");

    JPanel mainPanel = new JPanel(new BorderLayout(4,4));
    JPanel topPanel = new JPanel(new GridLayout(2, 1, 2, 2));
    JPanel lottoPanel = new JPanel(new GridLayout(6, 5, 2, 2));
    JPanel mousePanel = new JPanel(new GridLayout(6, 8, 2, 2));
    JPanel luckyPanel = new JPanel(new GridLayout(1, 9, 5, 2));
    JPanel lottoBottomPanel = new JPanel(new GridLayout(2, 1, 2, 2));
    JPanel mouseGameBottomPanel = new JPanel(new GridLayout(1, 1, 2, 2));
    JPanel luckyBottomPanel = new JPanel(new GridLayout(2, 2, 2, 2));

    JLabel title = new JLabel();
    JLabel description = new JLabel();
    JLabel statusLabel = new JLabel();
    JLabel winLabel = new JLabel();
    JLabel lossLabel = new JLabel();

    JButton submitButton= new JButton();

    Dimension nsDimensions = new Dimension(400, 50);
    Dimension buttonDimension = new Dimension(400, 60);
    Dimension luckyBottomDimension = new Dimension(500, 80);


    public GameBoardMaker()
    {
        setSize(WIDTH, HEIGHT);
        setLocationRelativeTo(null);
        setDefaultCloseOperation(HIDE_ON_CLOSE);
    }
}
