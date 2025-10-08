using GymMangementDAL.Entity.EntityEnum;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymMangementDAL.Entity
{
    internal abstract class GymUser: BaseEntity
    {

        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateOnly DataOfBirth {get; set; }
        public GenderUser GenderUser { get; set; }
        public Address Address { get; set; }

    }

    [Owned]
    class Address
    {
      public int BildingNumber { get; set; }
      public string Street { get; set; }
      public string City { get; set; }


    }


}
