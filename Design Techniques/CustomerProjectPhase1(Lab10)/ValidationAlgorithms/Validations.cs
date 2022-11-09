using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InterfaceCustomer;
namespace ValidationAlgorithms
{
    public class CustomerBasicValidation : IValidation<ICustomer>
    {
        public void Validate(ICustomer obj)
        {
            if (obj.CustomerName.Length == 0)
            {
                throw new Exception("Customer Name is required");
            }
        }
    }
    // Design pattern :- Decorator pattern
    public class ValidationLinker : IValidation<ICustomer>
    {
        private IValidation<ICustomer> nextvalidator = null;
        public ValidationLinker(IValidation<ICustomer> Ivalidation)
        {
            nextvalidator = Ivalidation;
        }
        public virtual void Validate(ICustomer obj)
        {
            nextvalidator.Validate(obj);
        }
    }
    public class PhoneValidation : ValidationLinker
    {
        public PhoneValidation(IValidation<ICustomer> custValidate)
            : base(custValidate)
        {

        }
        public override void Validate(ICustomer obj)
        {
            base.Validate(obj); // This will call the top of the cake
            if (obj.PhoneNumber.Length == 0)
            {
                throw new Exception("Phone number is compuls");
            }
        }
    }
    public class CustomerBillValidation : ValidationLinker
    {
        public CustomerBillValidation(IValidation<ICustomer> custValidate)
            : base(custValidate)
        {

        }
        public override void Validate(ICustomer obj)
        {
            base.Validate(obj);
            if (obj.BillAmount == 0)
            {
                throw new Exception("Bill Amount is required");
            }
            if (obj.BillDate >= DateTime.Now)
            {
                throw new Exception("Bill date  is not proper");
            }
        }
    }
    public class CustomerAddressValidation : ValidationLinker
    {
        public CustomerAddressValidation(IValidation<ICustomer> custValidate)
            : base(custValidate)
        {

        }
        public override void Validate(ICustomer obj)
        {
            base.Validate(obj);
            if (obj.Address.Length == 0)
            {
                throw new Exception("Address required");
            }
        }
    }

    public class CustomerBillAmountZeroValidation : ValidationLinker
    {
        public CustomerBillAmountZeroValidation(IValidation<ICustomer> custValidate)
            : base(custValidate)
        {

        }
        public override void Validate(ICustomer obj)
        {
            base.Validate(obj);
            if (obj.BillAmount != 0)
            {
                throw new Exception("This not appropriate");
            }
        }
    }
}
