//program 13
class circum
{
	double pi;
	double r;
	circum()
	{
		pi=3.14;
		r=7;
	}
	void find()//find circumfernce
	{
		double ans;
		ans=2*pi*r;
		System.out.println("\n circumfernce: " + ans);
	}
}
class circumference{
	public static void main(String args[])
	{
        circum c1=new circum();
		c1.find();
    }
}