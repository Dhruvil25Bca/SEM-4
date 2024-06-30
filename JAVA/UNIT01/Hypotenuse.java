//program 10
import javax.swing.*;
class Hypotenuse{
	public static void main(String args[])
	{
		int x,y;
		double hyp;
		String in=JOptionPane.showInputDialog(null,"Enter value of x: ");
		x=Integer.parseInt(in);
		String in2=JOptionPane.showInputDialog(null,"Enter value of y: ");
		y=Integer.parseInt(in2);
		hyp=Math.sqrt(((x*x)+(y*y)));
        System.out.println("Hypotenuse: "+hyp);
    }
}