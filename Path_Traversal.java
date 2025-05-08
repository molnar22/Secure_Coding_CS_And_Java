import java.io .*;

public class PathTraversalDemo {
  private static final String BASE_DIRECTORY = "safe_dir/";

  public static void main(String[] args) {
    if (args. length != 1) {
      System.out.println("Usage: java PathTraversalDemo <filename>");
      return;
    }

    String userInput = args[0];
    File file = new File(BASE_DIRECTORY + userInput);

    try (BufferedReader reader = new BufferedReader(new FileReader(file))) {
      System.out.println("Reading file: "+ file.getCanonicalPath());
      String line;
      while ((line = reader. readLine()) != null) {
        System.out.println(line);
      }
    } catch (IOException e) {
      System.out.println("Error: " + e.getMessage());
    }
  }
}
