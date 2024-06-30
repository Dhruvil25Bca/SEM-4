//program 08
import java.util.*;
class arithmetic{
	public static void main(String args[])
	{
		int a,b,x,ans=0;
		Scanner in=new Scanner(System.in);
        System.out.println("Enter value of a: ");
		a=in.nextInt();
		System.out.println("Enter value of b: ");
		b=in.nextInt();
		System.out.println("1. for addition ");
		System.out.println("2. for subtraction ");
		System.out.println("3. for multiplication ");
		System.out.println("4. for division ");
		System.out.println("Enter your choice: ");
		x=in.nextInt();
		switch(x)
		{
			case 1:
					ans=a+b;
					System.out.println(ans);
					break;
			case 2:
					ans=a-b;
					System.out.println(ans);
					break;
			case 3:
					ans=a*b;
					System.out.println(ans);
					break;
			case 4:
					ans=a/b;
					System.out.println(ans);
					break;
		}
    }
}
