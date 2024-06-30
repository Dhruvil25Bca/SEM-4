abstract class vehicle
{
	public abstract void numwheels();
}
class car extends vehicle
{
	public void numwheels()
	{
		System.out.println("car has four wheels");
	}
}
class truck extends vehicle
{
	public void numwheels()
	{
		System.out.println("Truck has six wheels");
	}
}
public class U2P6
{
	public static void main(String args[])
	{
		car c=new car();
		c.numwheels();
		truck t=new truck();
		t.numwheels();
	}
}