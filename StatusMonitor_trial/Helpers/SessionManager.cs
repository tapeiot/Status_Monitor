using StatusMonitor_trial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatusMonitor_trial.Helpers
{
    public sealed class SessionManager
    {
        private static readonly SessionManager instance = new SessionManager();
        public UserInfo CurrentUser { get; private set; }

        private SessionManager() { }

        public static SessionManager Instance
        {
            get { return instance; }
        }

        public void SetUser(UserInfo user)
        {
            CurrentUser = user;
        }
    }
}
