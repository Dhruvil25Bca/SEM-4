interface numbers
{
	public int process(int x,int y);
}
class sum implements numbers
{
	public int process(int x,int y)
	{
		return(x+y);
	}
}
class avg implements numbers
{
	public int process(int x,int y)
	{
		return((x+y)/2);
	}
}
public class U2P5
{
	public static void main(String args[])
	{
		int a,b;
		sum add=new sum();
		a=add.process(10,20);
		System.out.println("Sum: "+a);
		avg avg=new avg();
		b=avg.process(40,80);
		System.out.println("Average: "+b);
	}
}