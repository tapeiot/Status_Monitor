using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatusMonitor_trial.Models
{
    public class FieldCheckResult
    {
        public string PrinterName { get; set; }
        public bool IsConnected { get; set; }
        public Dictionary<string, string> FieldValues { get; set; } // Key = FieldName, Value = ค่าของ Field
        public string ErrorMessage { get; set; }

        public FieldCheckResult()
        {
            FieldValues = new Dictionary<string, string>();
        }
    }
}
