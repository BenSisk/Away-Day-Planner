using awayDayPlanner.Source.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting.ValidatorTests
{
    internal class AddressMock: IAddress
    {
        public int AddressID { get; set; }
        public string FirstLine { get; set; }
        public string SecondLine { get; set; }
        public string PostCode { get; set; }

        public AddressMock() 
        {
            this.AddressID = 1;
            this.FirstLine = "Test";
            this.SecondLine = "Test";
            this.PostCode = "Test";
        }
    }
}
