class quote{
	public static void main(String args[])
	{
		int i,n,low;
		String company[]={"LG","SAMSUNG","PHILIPS","SONY","MI"};
		int price[]={1000,20000,20020,50000,5000};
		n=price.length;
		low=price[0];
		for(i=1;i<n;i++)
		{
			if(low>price[i])
			{
				low=price[i];
			}
		}
		for(i=0;i<n;i++)
		{
				if(low==price[i])
				{
					System.out.println(company[i]);
				}
		}
    }
}