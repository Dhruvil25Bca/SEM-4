public class U3P5
{
	public static void main(String args[])
	{
		int a[]=new int[args.length];
		int temp,t;
		try{
			for(int i=0;i<args.length;i++)
			{
				a[i]=Integer.parseInt(args[i]);
			}
			for(int i=0;i<args.length;i++)
			{
				for(int j=i+1;j<args.length;j++)
				{
					if(a[i]<a[j])
					{
						temp=a[i];
						a[i]=a[j];
						a[j]=temp;
					}
				}
				System.out.println(" lowest "+a[0]+" Second lowest "+a[1]);
			}
		}
		catch(ArithmeticException e)
			{
				System.out.println("ArithmeticException occured");
			}
			catch(ArrayIndexOutOfBoundsException e)
			{
				System.out.println("ArrayIndexOutOfBoundsException cammand Line aruguments");
			}
			catch(NumberFormatException e)
			{
				System.out.println(" NumberFormatException "+"Enter Numbers only");
			}
			catch(Exception e)
			{
				System.out.println(""+e.getMessage());
			}
	}
}