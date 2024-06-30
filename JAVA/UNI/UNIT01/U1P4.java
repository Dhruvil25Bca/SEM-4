import javax.swing.*;
class U1P4{
	public static void main(String args[])
	{
		int a,b,c,max;
		String in1=JOptionPane.showInputDialog(null,"Enter value of a: ");
		a=Integer.parseInt(in1);
		String in2=JOptionPane.showInputDialog(null,"Enter value of b: ");
		b=Integer.parseInt(in2);
		String in3=JOptionPane.showInputDialog(null,"Enter value of c: ");
		c=Integer.parseInt(in3);
		max=a > b?(a > c? a :c):(b>c? b : c);
        System.out.println("Max among "+max);
    }
}
