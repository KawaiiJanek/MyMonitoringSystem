# Monitoring System

A simple logging system built in **C#** with **MS SQL Server** for storing application logs and critical alerts.

## 📂 Repository structure
- `/MonitoringApp` – C# application code with a simple logging service
  - `/Database` – SQL scripts for database setup
    - `CreateDatabase.sql` – creates `MonitoringDB` and tables (`SystemLogs`, `CriticalAlerts`)
    - `InsertSampleData.sql` – inserts sample test data

---

## ⚙️ Database installation

1. Open **SQL Server Management Studio (SSMS)**.  
2. Connect to your SQL Server instance (e.g. `localhost\SQLEXPRESS`).  
3. Run scripts in the following order:
   - `Database/CreateDatabase.sql` – creates `MonitoringDB` and required tables,  
   - `Database/InsertSampleData.sql` – inserts sample data for testing.  
4. Verify the data with:  

   ```sql
   USE MonitoringDB;
   SELECT * FROM SystemLogs;
   SELECT * FROM CriticalAlerts;
