import java.util.Scanner;
class EMI{
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
            EMI e=new EMI();
            e.get();
            e.Emi();
        }
}