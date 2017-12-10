using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeamLab.Buggy.Data
{
    public class Issue
    {

        public int ID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int ProjectID { get; set; }

        public string ProjectName { get; set; }

        public int CategoryID { get; set; }

        public string CategoryName { get; set; }

        //public List<Label> Labels { get; set; }

        public int StatusID { get; set; }

        public string StatusName { get; set; }

        public DateTime Created { get; set; }

        public DateTime LastUpdate { get; set; }

        public int CreatedBy { get; set; }

        public string CreatedByName { get; set; }

        public int AssignedTo { get; set; }

        public string AssignedToName { get; set; }

        public bool Active { get; set; }

    }
}
