using System;
using System.I0;

class Program {
  static string BaseDirectory = "/var/data/documents";

  static void Main(string[] args) {
    Console.Write("Enter the file name: ");
    string fileName = Console. ReadLine();

    string filePath = Path. Combine(BaseDirectory, fileName);

    if (!File. Exists(filePath)) {
      Console.WriteLine("File not found.");
      return;
    }
  
    string content = File.ReadAllText(filePath);
    Console.WriteLine("File content:\n" + content);
  }
}
