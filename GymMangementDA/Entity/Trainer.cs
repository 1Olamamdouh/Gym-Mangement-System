using GymMangementDAL.Entity.EntityEnum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymMangementDAL.Entity
{
    internal class Trainer: GymUser
    {
        //HireDate == CreatedAt

        public Specialities Specialities { get; set; }

    }
}
