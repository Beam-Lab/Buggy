using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeamLab.Buggy.Data
{
    public class HistoryEntry
    {

        public int ID { get; set; }

        public int IssueID { get; set; }

        public string Action { get; set; }

        public DateTime LastUpdate { get; set; }

        public int ActionBy { get; set; }

    }
}
