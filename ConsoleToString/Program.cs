using Microsoft.VisualBasic;
using System;

namespace ConsoleToString

{ 
    abstract class Bank
    {
        public string NameSurname { get; set; }
        public string CardNumber { get; set; }
        public int Cvv { get; set; }
        public decimal Balance { get; set; }    

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public void Withdrawal(decimal amount)
        {
            Balance -= amount;
        }

        public override string ToString()
        {
            return NameSurname + " " + CardNumber + " " + "Cvv:" + Cvv + " " + " Balance:" + " " + Balance + " " + "Azn";
        }
    }
     class Unibank : Bank
    {
        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public void Withdrawal(decimal amount)
        {

          Balance -= amount + (amount * 1.5m / 100);

        }
        public Unibank(string namesurname, string cardnumber, int cvv, decimal balance)
        {
            NameSurname = namesurname;
            CardNumber = cardnumber;
            Cvv = cvv;
            Balance = balance;
        }
    }
     class AccessBank : Bank
    {
        public void Deposit(decimal amount)
        {
            Balance += amount - (amount * 0.3m / 100);
        }

        public void Withdrawal(decimal amount)
        {

            Balance -= amount + (amount * 1.6m / 100);

        }
        public AccessBank(string namesurname, string cardnumber, int cvv, decimal balance)
        {
            NameSurname = namesurname;
            CardNumber = cardnumber;
            Cvv = cvv;
            Balance = balance;
        }

    }
     class PashaBank : Bank
    {
        public void Deposit(decimal amount)
        {
            Balance += amount - (amount * 0.6m / 100);
        }

        public void Withdrawal(decimal amount)
        {

            Balance -= amount + (amount * 1.1m / 100);

        }
        public PashaBank(string namesurname, string cardnumber, int cvv, decimal balance)
        {
            NameSurname = namesurname;
            CardNumber = cardnumber;
            Cvv = cvv;
            Balance = balance;
        }

    }
     class Leobank : Bank
    {
        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public void Withdrawal(decimal amount)
        {

            Balance -= amount;


        }
        public Leobank(string namesurname, string cardnumber, int cvv, decimal balance)
        {
            NameSurname = namesurname;
            CardNumber = cardnumber;
            Cvv = cvv;
            Balance = balance;
        }

            
        public class Program
        {
            public static void Main(string[] args)
            {
                Unibank Ucard = new Unibank("Azad Ibrahimli", "4098565225856632", 568, 400m);
                AccessBank AccessCard = new AccessBank("Azad Ibrahimli", "5298452566566253", 715, 500m);
                PashaBank PashaCard = new PashaBank("Azad Ibrahimli", "4227586555471236", 651, 300);
                Leobank Leocard = new Leobank("Azad Ibrahimli", "4098652633665412", 856, 800m);

                Ucard.Withdrawal(100);
                Ucard.Deposit(350);
                Console.WriteLine(Ucard);


                AccessCard.Withdrawal(100);
                AccessCard.Deposit(100);
                Console.WriteLine(AccessCard);


                PashaCard.Withdrawal(200);
                PashaCard.Deposit(200);
                Console.WriteLine(PashaCard);


                Leocard.Withdrawal(300);
                Leocard.Deposit(800);
                Console.WriteLine(Leocard);

            }

        }












    }


}