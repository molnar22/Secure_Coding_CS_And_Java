using System;
using System. Data. SQLite;

public class VulnerableDatabaseExample {
  
  public string ConnectionString { get; set; } = "Data Source=customer_data.db;Version=3;";

  public SQLiteConnection ConnectToDatabase(string username, string password) {

      string connectionString = string. Format("{0};User ID={1};Password={2}", ConnectionString, username, password);
      SQLiteConnection connection = new SQLiteConnection(connectionString);
      connection. Open();

      string query = "SELECT * FROM users WHERE username = '" + username + "'

      using (var cmd = new SQLiteCommand(query, connection)) {
        using (var reader = cmd. ExecuteReader()) {
          if (reader. HasRows) {
            Console.WriteLine("Successfully authenticated!");
          } else {
            Console.WriteLine("Authentication failed.");
          }
        }
     }
  }
}
  
