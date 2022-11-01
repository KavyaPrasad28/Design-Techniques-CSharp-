using DIPLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDIP
{
    /// <summary>
    /// The Dependency Inversion Principle (DIP) states that high-level modules/classes should not depend on low-level modules/classes. Both should depend upon abstractions. Secondly, abstractions should not depend upon details. Details should depend upon abstractions.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            IPerson owner = Factory.CreatePerson();
            owner.FirstName = "Kavya";
            owner.LastName = "Prasad";
            owner.EmailAddress = "kavya@gmail.com";
            owner.PhoneNumber = "9442340920";

            IChore chore = Factory.CreateChore();
            chore.ChoreName = "Take out the trash";
            chore.Owner = owner;



            chore.PerformedWork(3);
            chore.PerformedWork(1.5);
            chore.CompleteChore();
        }
    }
}
