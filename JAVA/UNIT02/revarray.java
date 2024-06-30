//program 06
class revarray{
	public static void main(String args[])
	{
		int i,arr[]={1,2,3,4,5};
		System.out.println("Before reverse");
		for(i=0;i<arr.length;i++)
		{
			System.out.println(arr[i]+" ");
		}
		System.out.println("After reverse");
		for(i=arr.length-1;i>=0;i--)
		{
			System.out.println(arr[i]+" ");
		}
    }
}