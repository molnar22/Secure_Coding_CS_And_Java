using System.IO;
using System. Security. Cryptography;
using System. Text;

class Program {
  public static void Main(string[] args) {
  string plaintext = "This is a secret message.";
  using (DESCryptoServiceProvider des = new DESCryptoServiceProvider()) {
    des.GenerateKey();
    des. GenerateIV();

    byte[] encrypted = Encrypt(plaintext, des.Key, des.IV);
    string decrypted = Decrypt(encrypted, des.Key, des.IV);

    Console.WriteLine("Original: " + plaintext);
    Console.WriteLine("Encrypted (Base64): " + Convert. ToBase64String(encrypted));
    Console.WriteLine("Decrypted: " + decrypted);
  }
}

public static byte[] Encrypt(string text, byte[] key, byte[] iv) {
  using (DESCryptoServiceProvider des = new DESCryptoServiceProvider()) {
  ICryptoTransform encryptor = des. CreateEncryptor(key, iv);
  using (MemoryStream ms = new MemoryStream()) {
      using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write)) {
        byte[] inputBytes = Encoding.UTF8.GetBytes(text);
        cs.Write(inputBytes, 0, inputBytes.Length);
        cs.FlushFinalBlock();
        return ms. ToArray();
      }
    }
  }
}
