/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package tpr5;

import javax.swing.*;
import java.awt.*;
import java.awt.event.MouseEvent;
import java.awt.event.MouseMotionAdapter;

/**
 *
 * @author robert.talabishka
 */
public class GUI extends JPanel{
    int x,y;
    int n=2;
    JPanel p;
    public GUI(){
    addMouseMotionListener(new MouseMotionAdapter(){
            public void mouseMoved(MouseEvent e) {
                    x = e.getX();
                    y = e.getY();
                    
                    repaint();
                    
                    
                    
    }
           
    });
    }
    
    public void paintComponent(Graphics g){
        this.setBackground(Color.WHITE);
        g.setColor(Color.black);
        g.drawOval(x, y, 50, 50);
   
    }
}
