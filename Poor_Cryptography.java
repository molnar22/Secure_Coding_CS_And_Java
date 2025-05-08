import javax.crypto.Cipher;
import javax.crypto. spec. IvParameterSpec;
import javax.crypto.spec. SecretKeySpec;
import java.nio.charset. StandardCharsets;
import java.security.SecureRandom;

public class Demo {

  private static final String STATIC_IV = "7cVgr5cbdCZVw5WY";

  public static void main(String[] args) {
    String key = "0123456789abcdef";
    String plaintext = "I never saw a wild thing sorry for itself.";
    encrypt(key, plaintext);
  }

  public static void encrypt(String key, String plainText) {
    try {
      IvParameterSpec iv = new IvParameterSpec(STATIC_IV.getBytes(StandardCharsets.UTF_8));
      SecretKeySpec keySpec = new SecretKeySpec(key.getBytes(StandardCharsets.UTF_8), "AES");

      Cipher cipher = Cipher.getInstance("AES/CBC/PKCS5Padding");
      cipher.init(Cipher. ENCRYPT_MODE, keySpec, iv);

      byte[] encrypted = cipher.doFinal(plainText.getBytes(StandardCharsets.UTF_8));
      System.out.println("Ciphertext (base64): " + java.util.Base64.getEncoder().encodeToString(encrypted));

    } catch (Exception e) {
      System.out.println("Encryption error: " + e.getMessage());
    }
  }
}
