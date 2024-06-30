//program 12
class area1
{
	int l;
	int b;
	area1()
	{
		l=9;
		b=5;
	}
	void rectangle()
	{
		int ans;
		ans=l*b;
		System.out.println("\n area of rectangle: "+ ans);
	}
	void square()
	{
		int ans;
		ans=l*l;
		System.out.println("\n area of square: "+ ans);
	}
}
class area{
	public static void main(String args[])
	{
        area1 a1=new area1();
		a1.rectangle();
		a1.square();
    }
}