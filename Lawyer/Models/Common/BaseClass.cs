using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lawyer.Models.Common
{
    public class BaseClass
    {
        public Guid Id { get; set; }
        public DateTime ?LastUpDate { get; set; }
        public bool ?IsActive { get; set; }

    }
}
