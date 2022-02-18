using Lawyer.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lawyer.Models.Account
{
    public class User: BaseClass
    {
        #region prop
       // public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
     //   public DateTime LastUpDate { get; set; }

        #endregion
    }
}
