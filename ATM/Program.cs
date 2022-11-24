internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");


        // See https://aka.ms/new-console-template for more information

        // atm machine  

        Console.WriteLine("trade Mark Vineet@2022");

        void printOptions()
        {
            Console.WriteLine("Please Choose form Options : ");
            Console.WriteLine("1.Deposit");
            Console.WriteLine("2.Withdrawl");
            Console.WriteLine("3.Show Balance");
            Console.WriteLine("4.Exit");
        }

        void deposit(cardHolder currentUser)
        {
            Console.WriteLine("How much $$ would you like to deposit ?");
            double deposit = Double.Parse(Console.ReadLine());
            currentUser.setBalance(deposit + currentUser.balance);

            Console.WriteLine("Thank You for your Transaction , Your new balaance is  : " + currentUser.getBalance());


        }

        void withdraw(cardHolder currentUser)
        {
            Console.WriteLine("How much $$ would you like to withdraw ?");
            double withdrawal = Double.Parse(Console.ReadLine());


            if (currentUser.getBalance() < withdrawal)
            {
                Console.WriteLine("Insufficent Balance !!");


            }
            else
            {
                currentUser.setBalance(currentUser.getBalance() - withdrawal);
                Console.WriteLine("Good To Go  , See you later !!");

            }

        }


        // get balance !! 


        void balance(cardHolder currentUser)
        {
            Console.WriteLine("Current Balance  : " + currentUser.getBalance());
        }

        List<cardHolder> cardHolders = new List<cardHolder>();
        cardHolders.Add(new cardHolder("22222", 1234, "Jhon", "Sergi", 150.23));
        cardHolders.Add(new cardHolder("7088",  7899 , "Vineet", "Verma", 15000000.23));

        //Prompt user   

        Console.WriteLine("Welcome !!");
        Console.WriteLine("Please Insert your debit card !!");

        String debitCardNum = "";
        cardHolder currentUser;

        while (true)
        {
            try
            {
                debitCardNum = Console.ReadLine();
                // check user DB 

                currentUser = cardHolders.FirstOrDefault(a => a.cardNum == debitCardNum);

                if (currentUser != null)
                {
                    break;

                }
                else
                {
                    Console.WriteLine("Card Not Found !!");

                }


            }
            catch
            {
                Console.WriteLine("Card Not Found !!");
            }
        }


        Console.WriteLine("Enter the Pin :: ");
        int userPin = 0;
        while (true)
        {
            try
            {
                userPin = int.Parse(Console.ReadLine());
                currentUser = cardHolders.FirstOrDefault(a => a.pin == userPin);

                if (currentUser != null)
                {
                    break;

                }
                else
                {
                    Console.WriteLine("Incorrect Pin  ,Please Try again !!");
                }
            }
            catch
            {
                Console.WriteLine("Incorrect Pin  ,Please Try again !!");
            }
        }

        Console.WriteLine("Welcome " + currentUser.getFirstname() + " :) ");

        int option = 0;

        do
        {
            printOptions();
            try
            {
                option = int.Parse(Console.ReadLine());
            }
            catch
            {

            }
            if (option == 1)
            {
                deposit(currentUser);
            }
            else if (option == 2)
            {
                withdraw(currentUser);

            }
            else if (option == 3)
            {
                balance(currentUser);
            }
            else if (option == 4)
            {
                break;
            }
            else
            {
                option = 0;

            }
        } while (option != 4);

        Console.WriteLine("Have a Nice Day !!");


    }




} 

public class cardHolder
{
    //  Console.WriteLine("hello vineet 343432");

   public String cardNum;
    public int pin;
    public String firstName;
    public String lastName;
    public double balance;

    public cardHolder(string cardNum, int pin, string firstName, string lastName, double balance)
    {
        this.cardNum = cardNum;
        this.pin = pin;
        this.firstName = firstName;
        this.lastName = lastName;
        this.balance = balance;
    }



    //getters

    public string getCardNum()
    {
        return cardNum;
    }
    public int getPin()
    {
        return pin;
    }

    public double getBalance()
    {
        return balance;
    }

    public string getFirstname()
    {
        return firstName;
    }

    public string getLastName()
    {
        return lastName;
    }

    //setters 
    public void setNum(string NewcardNum)
    {
        cardNum = NewcardNum;
    }
    public void setFirstName(string first)
    {
        firstName = first;
    }
    public void setLastName(string last)
    {
        lastName = last;
    }
    public void setPin(int newPin)
    {
        pin = newPin;
    }
    public void setBalance(double newBalance)
    {
        balance = newBalance;
    }

       

}