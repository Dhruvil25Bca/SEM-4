package pack2;
import pack1.*;
public class B
{
	public static void main(String args[])
	{
		A a1=new A();
		System.out.println("\n Instance variable "+a1.a);
		System.out.println("\n Instance method calling");
		a1.printA();
	}
}