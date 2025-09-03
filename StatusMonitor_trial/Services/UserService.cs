using StatusMonitor_trial.Models;
using System;
using System.Collections.Generic;
using System.Collections.Generic;
using System.Linq;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace StatusMonitor_trial.Services
{


    public static class UserService
    {

        private static readonly string dataFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "users.json");
        private static List<UserInfo> _users = new List<UserInfo>();
        public static void InitializeDefaultUser()
        {
            if (!_users.Any(u => u.Name == "admin"))
            {
                _users.Add(new UserInfo
                {
                    Name = "admin",
                    Password = "admin", 
                    Role = "Admin"
                });
            }
        }
        public static void SaveUsers()
        {
            var jsonString = JsonSerializer.Serialize(_users);
            File.WriteAllText(dataFile, jsonString);
        }

        public static void LoadUsers()
        {
            if (File.Exists(dataFile))
            {
                var jsonString = File.ReadAllText(dataFile);
                _users = JsonSerializer.Deserialize<List<UserInfo>>(jsonString);
            }
        }
        public static void AddUser(UserInfo user)
        {
            _users.Add(user);
            SaveUsers();
        }

        public static void RemoveUser(string name)
        {
            _users.RemoveAll(u => u.Name == name);
            SaveUsers();
        }

        public static void UpdateUser(UserInfo updatedUser)
        {
            var existingUser = _users.FirstOrDefault(p => p.Name == updatedUser.Name);
            if (existingUser != null)
            {
                existingUser.Name = updatedUser.Name;
                existingUser.Password = updatedUser.Password;
                existingUser.Role = updatedUser.Role;
            }
            SaveUsers();
        }

        public static List<UserInfo> GetUsers()
        {
            return _users.ToList();
        }

        public static UserInfo Login(string name, string password)
        {
            return _users.FirstOrDefault(u => u.Name == name && u.Password == password);
        }

    }

}
