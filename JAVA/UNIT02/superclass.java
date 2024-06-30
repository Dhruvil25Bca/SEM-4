//U02program14
class person
{
	int id;
	String name;
	person(int id,String name)
	{
		this.id=id;
		this.name=name;
	}
}
class Emp extends person
{
	float salary;
	Emp(int id,String name,float salary)
	{
		super(id,name);
		this.salary=salary;
	}
	void dis()
	{
		System.out.println(id+" "+name+" "+salary);
	}
}
class superclass{
	public static void main(String args[])
	{
		Emp e1=new Emp(9999,"Dr. darshna patel",125000f);
		e1.dis();
    }
}