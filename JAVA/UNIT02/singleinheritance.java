//U02Program09
class one
{
	public void print_one()
	{
		System.out.println("from parent class");
	}
}
class two extends one
{
	public void print_two()
	{
		System.out.println("from child class");
	}
}
class singleinheritance{
	public static void main(String args[])
	{
		two t=new two();
		t.print_one();
		t.print_two();
    }
}