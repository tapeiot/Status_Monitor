using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatusMonitor_trial.Models
{
    public class PrinterInfo
    {
        public string Name { get; set; }
        public string IP { get; set; }
        public int Port { get; set; }
        public DateTime LastEdited { get; set; }
    }
}
