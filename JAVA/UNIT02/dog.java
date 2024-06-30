//U02program16
abstract class animal
{
	public abstract void sound();
}
class dog extends animal
{
	public void sound()
	{
		System.out.println("Dog says: bow wow");
	}
	public static void main(String args[])
	{
		animal obj=new dog();
		obj.sound();
	}
}