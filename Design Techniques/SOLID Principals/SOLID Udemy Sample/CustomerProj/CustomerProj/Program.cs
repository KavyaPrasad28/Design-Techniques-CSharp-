using System;

namespace CustomerProj
{
    class Program
    {
        static void Main(string[] args)
        {
            //Interface segregation principle
            //old 1000 client
            ICustomer iold = new Customer();
            iold.Add();
            //new clients
            IRead newCust = new Customer();
            newCust.Add();
            newCust.Read();
        }
    }
    public interface IEnquiry
    {
        double CalculateDiscount();
    }
    public interface ICustomer : IEnquiry
    {
        void Add();
    }
    public interface IRead : ICustomer  // ISP :- Seperated interfaces
    {
        void Read();
    }
    public class Customer : ICustomer , IRead
    {
        public Customer()
        {
                
        }
        private IErrorhandler IErr;

        public Customer(IErrorhandler i) // Depedency inversion :- Error handler will come from outside
        {
            IErr = i;
        }
        public virtual double CalculateDiscount()
        {
            return 0;
        }
        public virtual void Add()
        {
            try
            {
                // Adds the customer Database 
            }
            catch (Exception ex)
            {
                IErr.HandleError(ex.ToString());
            }
        }

        public void Read()
        {
            // reading from database code will go here.
        }
    }
    
    public class GoldCustomer : Customer // OPEN closed principle - new classes are created by inheritance
    {
        public override double CalculateDiscount()
        {
            return base.CalculateDiscount() + 10;
        }
    }
    
    public class SilverCustomer : Customer
    {
        public override double CalculateDiscount()
        {
            return base.CalculateDiscount() + 5;
        }
    }
    public class EquiryCustomer : IEnquiry // LISKOV Ienquiry and Icustomer interface created 
    {

        public double CalculateDiscount()
        {
            return 2;
        }
        
    }
    
    public interface IErrorhandler
    {
        void HandleError(string err);
    }
    public class FileErrorhandler : IErrorhandler // SRP ( Created a new class for error handling)
    {
        public void HandleError(string err)
        {
            System.IO.File.
                   WriteAllText(@"c:\Error.txt", err);
        }
    }
    public class EventVwrErr : IErrorhandler
    {
        public void HandleError(string err)
        {
            // Handle errors in event viewer
        }
    }
}
