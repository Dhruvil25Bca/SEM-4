//program 07
import java.util.*;
class summatrix{
	public static void main(String args[])
	{
		int m,n,c,d;
		Scanner in=new Scanner(System.in);
		System.out.println("Enter the number of rows and columns of matrix: ");
		m=in.nextInt();
		n=in.nextInt();
		int first[][]=new int[m][n];
		int second[][]=new int[m][n];
		int sum[][]=new int[m][n];
		System.out.println("Enter the elements of first matrix: ");
		for(c=0;c<m;c++)
		{
			for(d=0;d<n;d++)
			{
				first[c][d]=in.nextInt();
			}
		}
		System.out.println("Enter the elements of second matrix: ");
		for(c=0;c<m;c++)
		{
			for(d=0;d<n;d++)
			{
				second[c][d]=in.nextInt();
			}
		}
		for(c=0;c<m;c++)
		{
			for(d=0;d<n;d++)
			{
				sum[c][d]=first[c][d]+second[c][d];
			}
		}
		System.out.println("Sum of the matrices: ");
		for(c=0;c<m;c++)
		{
			for(d=0;d<n;d++)
			{
				System.out.print(sum[c][d]+" ");
			}
			System.out.println();
		}
    }
}