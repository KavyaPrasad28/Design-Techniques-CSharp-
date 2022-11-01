using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSOLID_sample
{
    //OCP
    public class NumberInputs
    {
        public int FirstNumber { get; set; } = 5;
        public int SecondNumber { get; set; } = 2;
    }
    public abstract class BaseCalculator : NumberInputs
    {
        public abstract int Operation();
    }
    public class Addition : BaseCalculator
    {
        public override int Operation()
        {
            int add = FirstNumber + SecondNumber;
            return add;
        }
    }
    public class Subtraction : BaseCalculator
    {
        public override int Operation()
        {
            int sub = FirstNumber - SecondNumber;
            return sub;
        }
    }
    /*public class Calculator : NumberInputs
    {
        //Include other operations if demands came
        public int Operation()
        {
            int add = FirstNumber + SecondNumber;
            return add;
        }
    }*/
    //SRP
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //public void DataEntry()
        //{
        //    Console.Write("Your first name:");
        //    FirstName = Console.ReadLine();

        //    Console.Write("Your last name:");
        //    LastName = Console.ReadLine();
        //}
    }
    public class PersonDataEntry
    {
        public static Person Entry()
        {
            Person output = new Person();

            Console.Write("Your first name:");
            output.FirstName = Console.ReadLine();

            Console.Write("Your last name:");
            output.LastName = Console.ReadLine();

            return output;
        }
    }
    //DIP
    public class BusinessLogicLayer
    {
        private readonly IRepositoryLayer RL;
        public BusinessLogicLayer(IRepositoryLayer repositoryLayer)
        {
            RL = repositoryLayer;
        }
        public void Save(Object details)
        {
            RL.Save(details);
        }
    }
    public interface IRepositoryLayer
    {
        void Save(Object details);
    }
    public class DataAccessLayer : IRepositoryLayer
    {
        public void Save(Object details)
        {
            //perform save
        }
    }
    //ISP
    /*public interface ILibrary
    {
        bool CanBorrow(string content);
        bool CanListen(string content);
    }*/
    public interface ILibraryBorrowable
    {
        bool CanBorrow(string content);
    }
    public interface ILibraryListenable
    {
        bool CanListen(string content);
    }
    class Book : ILibraryBorrowable
    {
        public bool CanBorrow(string content)
        {
            return true;
        }
    }
    class AudioBook : ILibraryListenable
    {
        public bool CanListen(string content)
        {
            return true;
        }
    }
    //LSP
    /*public class SumCalculator
    {
        protected readonly int[] _numbers;
        public SumCalculator(int[] numbers) {_numbers = numbers;}
        public int Calculate() { return _numbers.Sum(); }
    }
    public class EvenNumbersSumCalculator : SumCalculator
    {
        public EvenNumbersSumCalculator(int[] numbers) : base(numbers) { }
        public new int Calculate()
        {
            return _numbers.Where(x => x % 2 == 0).Sum();
        }
    }*/
    public abstract class Calculator
    {
        protected readonly int[] _numbers;
        public Calculator(int[] numbers) { _numbers = numbers; }
        public abstract int Calculate(); 
    }
    public class SumCalculator : Calculator
    {
        public SumCalculator(int[] numbers) : base (numbers){ }
        public override int Calculate() { return _numbers.Sum();}
    }
    public class EvenNumbersSumCalculator : Calculator
    {
        public EvenNumbersSumCalculator(int[] numbers) : base(numbers) { }
        public override int Calculate() { return _numbers.Where(x => x % 2 == 0).Sum(); }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 2, 1, 3, 5, 4 };
            Calculator sum = new SumCalculator(numbers);
            Console.WriteLine($"The sum of all the numbers: {sum.Calculate()}\n");
            Calculator eSum = new EvenNumbersSumCalculator(numbers);
            Console.WriteLine($"The sum all even numbers: {eSum.Calculate()}\n");
        } }
}
