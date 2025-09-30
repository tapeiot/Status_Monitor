using StatusMonitor_trial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace StatusMonitor_trial
{
    public class PrinterConnection : IDisposable
    {
        public PrinterInfo Info { get; set; }
        public TcpClient Client { get; private set; }
        public NetworkStream Stream => Client?.GetStream();
        public bool IsConnected => Client?.Connected ?? false;

        public PrinterConnection(PrinterInfo info)
        {
            Info = info;
        }

        public async Task<bool> ConnectAsync()
        {
            try
            {
                Client = new TcpClient();
                await Client.ConnectAsync(Info.IP, Info.Port).WaitAsync(TimeSpan.FromSeconds(3));
                return true;
            }
            catch
            {
                return false;
            }
        }
        public void Disconnect()
        {
            if (IsConnected)
            {
                Stream?.Close();
                Client?.Close();
            }
        }
        public async Task SendAsync(string message)
        {
            if (!IsConnected) throw new Exception("Not connected.");
            byte[] buffer = Encoding.ASCII.GetBytes(message + "\r"); 
            await Stream.WriteAsync(buffer, 0, buffer.Length);
        }

        public async Task<string> ReadAsync()
        {
            if (!IsConnected) throw new Exception("Not connected.");
            byte[] buffer = new byte[4096];
            int bytesRead = await Stream.ReadAsync(buffer, 0, buffer.Length);
            return Encoding.ASCII.GetString(buffer, 0, bytesRead).Trim('\r', '\n');
        }

        public void Dispose()
        {
        Stream?.Close(); 
        Client?.Close(); 
        Client?.Dispose();
        }
    }
}