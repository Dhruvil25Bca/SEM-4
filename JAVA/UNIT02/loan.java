//U02program20
interface home
{
	void homeloan();
}
interface car
{
	void carloan();
}
interface education
{
	void educationloan();
}
public class loan implements home,car,education
{
	public void homeloan()
	{
		System.out.println("Rate of interest on home loan is 16.50%");
	}
	public void carloan()
	{
		System.out.println("Rate of interest on home loan is 11.25%");
	}
	public void educationloan()
	{
		System.out.println("Rate of interest on education loan is 10.50%");
	}
	public static void main(String args[])
	{
		loan l=new loan();
		l.homeloan();
		l.carloan();
		l.educationloan();
		
	}
}