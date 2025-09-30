
using System;
using System.Threading.Tasks;

namespace MonitoringApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // ---> Certyfikat self-signed
            var connectionString = "Server=GIGAKONKUTER\\SQLEXPRESS;Database=MonitoringDB;Trusted_Connection=True;TrustServerCertificate=True;";

            var logger = new LoggingService(connectionString);

            Console.Write("Podaj swoje imię: ");
            var user = Console.ReadLine();

            var id = await logger.LogAsync(user ?? "unknown", "DemoStart", "INFO", $"User {user} started the demo");
            Console.WriteLine($"Wstawiono log o ID = {id}");

            // kilka przykładowych wpisów
            await logger.LogAsync("system", "BatchJob", "WARN", "Job took longer than expected");
            await logger.LogAsync("jan.kowalski", "UpdateOrder", "ERROR", "Order update failed: missing data");
            await logger.LogAsync("admin", "DeleteUser", "CRITICAL", "Unauthorized deletion attempt");

            Console.WriteLine("Gotowe. Sprawdź tabele Logs i CriticalAlerts w SSMS.");
            Console.ReadKey();
        }
    }
}
