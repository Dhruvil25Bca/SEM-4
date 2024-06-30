//U02program19
interface cal_area
{
	final float pi=3.14f;
	public float area(int x);
	public void shape();
}
class square implements cal_area
{
	public float area(int x)
	{
		return x*x;
	}
	public void shape()
	{
		System.out.println("From Square");
	}
}
class circle implements cal_area
{
	public float area(int x)
	{
		return pi*x*x;
	}
	public void shape()
	{
		System.out.println("From Circle");
	}
}
public class interfacedemo
{
	public static void main(String args[])
	{
		square s=new square();
		System.out.println("Area of Square: "+s.area(2));
		s.shape();
		circle c=new circle();
		System.out.println("Area of Square: "+c.area(2));
		c.shape();	
	}
}