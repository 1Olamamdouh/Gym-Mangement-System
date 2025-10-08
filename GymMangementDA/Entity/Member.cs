using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymMangementDAL.Entity
{
    internal class Member: GymUser
    {
        //JoinData == CreatedAt
        public string? Photo { get; set; }


    }
}
