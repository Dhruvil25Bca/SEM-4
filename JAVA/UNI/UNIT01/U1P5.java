import java.util.Scanner;
class U1P5{
	public static void main(String args[])
	{
		int x,y;
		double hyp;
		Scanner in = new Scanner(System.in);
		System.out.print("Enter value of x: ");
		x=in.nextInt();
		System.out.print("Enter value of y: ");
		y=in.nextInt();
		hyp=Math.sqrt(((x*x)+(y*y)));
        System.out.println("Hypotenuse: "+hyp);
    }
}
