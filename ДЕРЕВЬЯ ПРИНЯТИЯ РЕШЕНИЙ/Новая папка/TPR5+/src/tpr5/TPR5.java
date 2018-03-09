/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package tpr5;

import java.awt.Color;
import javax.swing.*;

/**
 *
 * @author robert.talabishka
 */
public class TPR5 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        JFrame frame = new JFrame();
        
        
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        
        GUI gui = new GUI();
        frame.add(gui);
        frame.setSize(500, 300);
        frame.setVisible(true);
        
    }
    
}
