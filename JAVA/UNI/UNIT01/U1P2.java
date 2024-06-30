import java.util.Scanner;
class U1P2
{
		int loan;
        double intr;
        double emi;
        Scanner in=new Scanner(System.in);
        void get()
        {
            System.out.print("Enter loan : ");
            loan=in.nextInt();
            System.out.print("Enter interest : ");
            intr=in.nextDouble();
        }
        
        void Emi()
        {
            emi=loan*intr/(100*60);
            System.out.println("Emi of loan is : "+emi);
        }
        public static void main(String args[])
        {
            U1P2 e=new U1P2();
            e.get();
            e.Emi();
        }
}
