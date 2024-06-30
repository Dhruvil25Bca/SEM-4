import java.util.*;
interface exam
{
	boolean pass(int mark);
}
interface classify
{
	String division(int avg);
}
class result implements exam,classify
{
	public boolean pass(int mark)
	{
		if(mark>=35)
		{
			return true;
		}
		else
		{
			return false;
		}
	}
	public String division(int avg)
	{
		if(avg>=70)
		{
			return "DIST";
		}
		else if(avg>=60)
		{
			return "FIRST";
		}
		else if(avg>=50)
		{
			return "SECOND";
		}
		else
		{
			return "no-division";
		}
	}
}
public class U2P7
{
	public static void main(String args[])
	{
		boolean pass;
		int mark,avg;
		String division;
		Scanner in=new Scanner(System.in);
		result res=new result();
		System.out.print("Enter marks: ");
		mark=in.nextInt();
		System.out.print("Enter Average: ");
		avg=in.nextInt();
		pass=res.pass(mark);
		division=res.division(avg);
		if(pass)
		{
			System.out.println("\n Passed-"+division+".");
		}
		else
		{
			System.out.println("\n Failed-"+division+".");
		}
	}
}