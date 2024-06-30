//U02program15
class parentclass{
	parentclass()
	{
		System.out.println("Parent class constructor");
	}
}
class subclass{
	subclass()
	{
		System.out.println("Child class constructor");
	}
	subclass(int num)
	{
		System.out.println("Parameterized Constructor of child class: "+num);
	}
	void dis()
	{
		System.out.println("Hello from dis method of Child class");
	}
	public static void main(String args[])
	{
		subclass sub=new subclass();
		sub.dis();
		subclass sub2=new subclass(10);
		sub2.dis();
    }
}