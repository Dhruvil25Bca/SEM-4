abstract class vegetable
{
	public String color;
}
class potato extends vegetable
{
	public String toString()
	{
		color="Brown-skinned color";
		return "potato -->"+color;
	}
}
class brinjal extends vegetable
{
	public String toString()
	{
		color="Purple color";
		return "Brinjal -->"+color;
	}
}
class tomato extends vegetable
{
	public String toString()
	{
		color="red color";
		return "Tomato -->"+color;
	}
}

public class U2P9
{
	public static void main(String args[])
	{
		potato p=new potato();
		brinjal b=new brinjal();
		tomato t=new tomato();
		System.out.println(p);
		System.out.println(b);
		System.out.println(t);
	}
}