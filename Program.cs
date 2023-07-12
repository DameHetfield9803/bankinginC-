namespace program {
    public class Program
    {

        static double wd() {
            Console.WriteLine("Please enter an amount that you would like to withdraw > \n");
            string c = Console.ReadLine();
            double z = Convert.ToDouble(c);
            // Making z the amount withdrawn
            double output = depo() - z;
            if (z > depo())
            {
                Console.WriteLine("You do not have enough money in your balance to do so! \n");
            }
            else { 
                Console.WriteLine("${0} successfully withdrawn! Your new bank balance is {1} \n", z, output);
            }
            return output;
        }

        static double depo()
        {
            double x;
            Console.WriteLine("Please enter how much you want to deposit > \n");
            string ipt = Console.ReadLine();
            double output = Convert.ToDouble(ipt);
            Console.WriteLine("Your new balance is > {0}\n", output);
            return output;
        }

        static double balance()
        {
            double ttl;

            ttl = depo() - wd();
            Console.WriteLine("Balance left > {0} \n", ttl);

            return ttl;

        }

        static int opt() {
            int i = 0;
            Console.WriteLine("Please type in a number between 1-4 for this banking system > \n");
            Console.WriteLine("1. Make a deposit to your balance \n");
            Console.WriteLine("2. Withdraw from your balance \n");
            Console.WriteLine("3. Check your balance \n");
            Console.WriteLine("4. Quit \n");
            string c = Console.ReadLine();
            i = Convert.ToInt32(c);
            while (i!= 4){
                switch (i)
                {
                    case 1:
                        depo();
                        break;
                    case 2:
                        wd();
                        break;
                    case 3:
                        balance();
                        break;
                    default:
                        Console.WriteLine("PLEASE ENTER A VALID NUMBER BETWEEN 1-4 \n");
                        break;
                }
                if (i == 4) {
                    Console.WriteLine("Thank you for using the banking app, hope to see you soon! \n");
                    break;
                }
            }
            return opt();
        }

        static void Main(string[] args)
        {
            opt();
        }
    }
}
