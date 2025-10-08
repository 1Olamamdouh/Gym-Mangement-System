using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymMangementDAL.Entity
{
    internal class Session : BaseEntity
    {
        public int Capacity { get; set; }
        public string Duration { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDataTime { get; set; }
    }
}
