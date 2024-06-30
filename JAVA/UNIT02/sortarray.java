//program 05
class sortarray{
	public static void main(String args[])
	{
		int i,j,n,temp;
		n=args.length;
		int a[]=new int[n];
		for(i=0;i<n;i++)
		{
			a[i]=Integer.parseInt(args[i]);
		}
		for(i=0;i<n;i++)
		{
			for(j=i+1;j<n;j++)
			{
				if(a[i]>a[j])
				{
					temp=a[i];
					a[i]=a[j];
					a[j]=temp;
				}
			}
		}
		System.out.println("After sorting:");
		for(i=0;i<n;i++)
		{
			System.out.println(a[i]);
		}
    }
}