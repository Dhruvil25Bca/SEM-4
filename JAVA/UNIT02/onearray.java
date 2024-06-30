//U02 program 01
class onearray{
	public static void main(String args[])
	{
		int i;
		int sum=0;
		int marks[]=new int[5];
		marks[0]=80;
		marks[1]=90;
		marks[2]=70;
		marks[3]=50;
		marks[4]=60;
		for(i=0;i<marks.length;i++)
		{
			sum+=marks[i];
		}
        System.out.println("\n sum: "+sum);
    }
}