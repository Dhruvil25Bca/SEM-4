package p;
public class pack
{
	public int findmax(int a,int b,int c)
	{
		int max=((a>b)?((a>c)?a:c):((b>c)?b:c));
		return(max);
	}
}