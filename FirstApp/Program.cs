

namespace FirstApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        string[] name = new string[3];
        static void Main(string[] args)
        {
            Program program = new Program();
            program.FindAverageOfGivenNumbers();
        }

        private   void FindAverageOf10Numbers()
        {
           int[] numbers = new int[10];
           int sum=0;
           for (int i = 0; i < 10; i++)
           {
               System.Console.WriteLine("Please enter the numebr");
               numbers[i] = Convert.ToInt32(Console.ReadLine());
                sum += numbers[i];
            }
            float average = sum/10;
            System.Console.WriteLine("The average is "+average);
        }
        private   void FindAverageOfGivenNumbers()
        {
           //int[] numbers = new int[10];
           List<int> numbers = new List<int>();
           int sum=0,number =0;
          do
           {
               System.Console.WriteLine("Please enter the numebr");
               number= Convert.ToInt32(Console.ReadLine());
               if(number>=0)
               {
                sum += number;
                numbers.Add(number);
               }
            }while(number >=0);
            float average = sum/(numbers.Count);
            var distinction = numbers.Where(n=>n>70);
            foreach (var item in distinction)
            {
                System.Console.WriteLine(item);
            }
            System.Console.WriteLine("The average is "+average);
        }

         void PrintNames(){
            name[0] = "Tim";
            name[1] = "Jim";
            name[2] = "Lim";
            for (int i = 0; i < 3; i++)
            {
                name[i] = "Hello "+name[i];
                System.Console.WriteLine(name[i]);
            }
            foreach (var item in name)
            {
                System.Console.WriteLine(item);
            }
        }

        private void InteractWithUser()
        {
            int choice =0;
            do
            {
                System.Console.WriteLine("Please enter your option");
                choice = Convert.ToInt32(Console.ReadLine());
                PrintMenu();
                ChooseMethod(choice);
            }while(choice != 0);
        }

        private void ChooseMethod(int choice)
        {
            
            switch (choice)
            {
                case 1: 
                    System.Console.WriteLine("Register yourself");
                    break;
                case 2: 
                    System.Console.WriteLine("Login with your cred");
                    break;
                case 3:
                    System.Console.WriteLine("Meno here goes");
                    break;
                case 0:
                    System.Console.WriteLine("Byeeeee....");
                    break;
                default:
                    System.Console.WriteLine("Invalid entry");
                    break;
            }
        }

        private void PrintMenu()
        {
            System.Console.WriteLine("Welcoem to the application");
            System.Console.WriteLine("1. Register");
            System.Console.WriteLine("2. Login");
            System.Console.WriteLine("3. View Menu");
            System.Console.WriteLine("0. Exit");
        }
    }
}