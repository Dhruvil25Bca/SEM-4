//U02program11
class get
{
	int l,b;
	get()
	{
		l=15;
		b=20;
	}
}
class cal extends get
{
	double Sarea,Spara,Rarea,Rpara;
	public void find()
	{
		Sarea=l*l;
		Spara=4*l;
		Rarea=l*b;
		Rpara=2*(l*b);
	}
}
class dis extends cal
{
	public void print()
	{
		System.out.println("Square area: "+Sarea);
		System.out.println("Square parameter: "+Spara);
		System.out.println("Rectangle area: "+Rarea);
		System.out.println("Rectangle parameter: "+Rpara);
	}
}
class findarea{
	public static void main(String args[])
	{
		dis d1=new dis();
		d1.find();
		d1.print();
    }
}