class area
{
void area(int l,int b)
	{
		int ans;
		ans=l*b;
		System.out.println("\n area of rectangle: "+ ans);
	}
void area(int l)
	{
		int ans;
		ans=l*l;
		System.out.println("\n area of square: "+ ans);
	}
}
class U1P6{
	public static void main(String args[])
	{
		int l;
		int b;
		l=Integer.parseInt(args[0]);
		b=Integer.parseInt(args[1]);
        area a1=new area();
		a1.area(l);
		a1.area(l,b);
    }
}