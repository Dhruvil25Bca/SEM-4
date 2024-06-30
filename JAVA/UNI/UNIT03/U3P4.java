class U3P4{
	public static void main(String args[])
	{
		char c[]=args[0].toCharArray();
		System.out.println("\n Display each character on seperate line in reverse order");
		for(int i=c.length-1;i>=0;i--)
		{
			System.out.println(c[i]);
		}
		System.out.println("\n count total number of character and display each character's position");
		System.out.println("\n Total number of characters are "+c.length);
		for(int i=0;i<c.length;i++)
		{
			System.out.println(c[i]+" character is at "+i+" position");
		}
		System.out.println("\n identify the string is palindrom or not");
		StringBuffer s1=new  StringBuffer(args[0]);
		StringBuffer s2=s1.reverse();
		if(s1.equals(s2))
		{
			System.out.println("\n String is palindrom");
		}
		else
		{
			System.out.println("\n String is not palindrom");
		}
		System.out.println("\n Total nubmer of uppercase and lowercase characters");
		int up=0,lw=0;
		for(int i=0;i<c.length;i++)
		{
			if(Character.isUpperCase(c[i]))
			{
				up++;
			}
			else
			{
				lw++;
			}
		}
		System.out.println("\n Uppercase Characters are: "+up);
		System.out.println("\n Lowercase Characters are: "+lw);
	}
}
