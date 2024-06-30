class validatestring extends Exception
{
	validatestring(String s)
	{
		System.out.println("\n String is not valid");
	}
}

class u3p6
{
	public static void main(String args[])
	{
		String s=args[0];
		char c[]=s.toCharArray();
		int flag=0;
		try
		{
			if(s.length()<=5)
			{
				for(int i=0 ; i<s.length(); i++)
				{
					if(Character.isDigit(c[i]))
					{
						flag=1;
						System.out.println("\n String is valid");
						break;
					}
				}
				if(flag==0)
				{
					throw new validatestring(s);
				}
			}
			else
			{
				throw new validatestring(s);
			}
		}
		catch(Exception e)
		{}
		//System.out.println("Hello World");	
	}
}