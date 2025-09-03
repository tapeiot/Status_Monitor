using StatusMonitor_trial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace StatusMonitor_trial.Services
{

    public static class PathService
    {
        private static readonly string dataFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "path.json");
        private static List<PathInfo> _paths = new List<PathInfo>();
        public static event EventHandler PathListChanged;

        public static List<PathInfo> GetPaths()
        {
            return _paths.ToList();
        }
        public static void SavePath()
        {
            var jsonString = JsonSerializer.Serialize(_paths);
            File.WriteAllText(dataFile, jsonString);
        }

        public static void LoadPath()
        {
            if (File.Exists(dataFile))
            {
                var jsonString = File.ReadAllText(dataFile);
                _paths = JsonSerializer.Deserialize<List<PathInfo>>(jsonString);
            }
        }
        public static void AddPath(PathInfo path)
        {
            _paths.Add(path);
            PathListChanged?.Invoke(null, EventArgs.Empty);
            SavePath();
        }

        public static void DeletePath(string name)
        {
            _paths.RemoveAll(p => p.Name == name);
            PathListChanged?.Invoke(null, EventArgs.Empty);
            SavePath();
        }

        public static void UpdatePath(PathInfo updatePath)
        {
            var existingPath = _paths.FirstOrDefault(p => p.Name == updatePath.Name);
            if (existingPath != null)
            {
                existingPath.Path = updatePath.Path;
                existingPath.Type = updatePath.Type;
            }
            PathListChanged?.Invoke(null, EventArgs.Empty);
            SavePath();

        }
        public static void OpenPath(string name)
        {
            var pathInfo = _paths.FirstOrDefault(p => p.Name == name);
            if (pathInfo != null)
            {
                try
                {
                    var startInfo = new System.Diagnostics.ProcessStartInfo
                    {
                        FileName = pathInfo.Path,
                        UseShellExecute = true 
                    };
                    System.Diagnostics.Process.Start(startInfo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error opening path: {ex.Message}");
                }
            }
        }
    }
}
