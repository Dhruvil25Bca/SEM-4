//U02 program 02
class arrayfor{
	public static void main(String args[])
	{
		int sum=0;
		int marks[]={50,60,70,80,90};
		for(int value:marks)
		{
			sum+=value;
		}
        System.out.println("\n sum: "+sum);
    }
}