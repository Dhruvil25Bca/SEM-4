//program 06
class square1to10{
	public static void main(String args[])
	{
		int i;
		int square[]=new int[11];
		int num=10;
		for(i=1;i<=num;i++)
		{
			square[i]=i*i;
		}
		for(i=1;i<=num;i++)
		{
			System.out.println("Square of "+i+" is "+square[i]);
		}
    }
}
