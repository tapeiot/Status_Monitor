using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatusMonitor_trial.Helpers
{
    public class FormManager
    {

        private static Dictionary<Type, Form> _openForms = new Dictionary<Type, Form>();

        public static void OpenForm<T>(Form currentForm) where T : Form, new()
        {
            currentForm.Hide();

            Form nextForm;

            if (_openForms.ContainsKey(typeof(T)))
            {
                nextForm = _openForms[typeof(T)];
            }
            else
            {
                nextForm = new T();
                _openForms.Add(typeof(T), nextForm);
            }
            if (nextForm is IRefreshable refreshableForm)
            {
                refreshableForm.LoadLogData();
            }
            nextForm.Show();
        }
    }
}
