//U02program13
class student
{
	double rollno,sub1,sub2,sub3;
	double total,percentage;
	String name;
}
class data extends student
{
	public void getdata()
	{
		rollno=13;
		name="Chirag";
		sub1=70;
		sub2=70;
		sub3=70;
		total=sub1+sub2+sub3;
		percentage=total/3;
	}
}
class print extends data
{
	public void dis()
	{
		System.out.println("Rollno: "+rollno);
		System.out.println("Name of student: "+name);
		System.out.println("Subject1: "+sub1);
		System.out.println("Subject2: "+sub2);
		System.out.println("Subject3: "+sub3);
		System.out.println("Total of 3 subjects: "+total);
		System.out.println("percentage: "+percentage);
	}
}
class result{
	public static void main(String args[])
	{
		print p1=new print();
		p1.getdata();
		p1.dis();
    }
}
