using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatusMonitor_trial.Helpers
{
    public class FormManager
    {
        public static void OpenForm(Form currentForm, Form newForm)
        {

            currentForm.Hide();

            newForm.Show();
        }
    }
}
