//U01program07
class complex
{
	int real,imag;
	complex()
	{
	}
	complex(int real1,int imag1)
	{
		real=real1;
		imag=imag1;
	}
	complex addcomplex(complex c1,complex c2)
	{
		complex csum=new complex();
		csum.real=c1.real+c2.real;
		csum.imag=c1.imag+c2.imag;
		return csum;
	}
	complex subcomplex(complex c1,complex c2)
	{
		complex csub=new complex();
		csub.real=c1.real-c2.real;
		csub.imag=c1.imag-c2.imag;
		return csub;
	}
	complex mulcomplex(complex c1,complex c2)
	{
		complex cmul=new complex();
		cmul.real=c1.real*c2.real-c1.imag*c2.imag;
		cmul.imag=c1.imag*c2.imag+c1.real*c2.real;
		return cmul;
	}
}
public class U1P7 
{
	public static void main(String args[])
	{
		complex c1=new complex(4,8);
		complex c2=new complex(5,7);
		complex c3=new complex(3,4);
		c3=c3.addcomplex(c1,c2);
		System.out.println("Sum: "+c3.real+"+i"+c3.imag);
		c3=c3.subcomplex(c1,c2);
		System.out.println("Sub: "+c3.real+"+i"+c3.imag);
		c3=c3.mulcomplex(c1,c2);
		System.out.println("mul: "+c3.real+"+i"+c3.imag);
	}
}