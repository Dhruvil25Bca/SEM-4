abstract class shape
{
	abstract void area();
	double area;
}
class triangle extends shape
{
	double b=60,h=20;
	void area()
	{
		area=(b*h)/2;
		System.out.println("Area of triangle: "+area);
	}
}
class rectangle extends shape
{
	double w=80,h=10;
	void area()
	{
		area=w*h;
		System.out.println("Area of rectangle: "+area);
	}
}
class U2P8{
	public static void main(String args[])
	{
		triangle t=new triangle();
		rectangle r=new rectangle();
		t.area();
		r.area();
    }
}