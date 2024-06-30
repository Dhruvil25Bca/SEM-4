//U02program10
class area
{
	int l=8,b=10;
	public void areaR()
	{
		int ans;
		ans=l*b;
		System.out.println("Rarea: "+ans);
	}
}
class parameter extends area
{
	public void print()
	{
		int para;
		para=2*(l*b);
		System.out.println("parameter of Rarea: "+para);
	}
}
class p10{
	public static void main(String args[])
	{
		parameter p=new parameter();
		p.areaR();
		p.print();
    }
}