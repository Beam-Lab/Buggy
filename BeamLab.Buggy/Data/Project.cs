using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeamLab.Buggy.Data
{
    public class Project
    {

        public int ID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime DueDate { get; set; }

        public bool Active { get; set; }

        public int OwnerID { get; set; }

        public string OwnerName { get; set; }
    }
}
