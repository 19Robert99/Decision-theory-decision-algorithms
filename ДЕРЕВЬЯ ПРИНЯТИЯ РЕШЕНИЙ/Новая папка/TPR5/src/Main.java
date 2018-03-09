
import java.io.IOException;
import java.nio.charset.StandardCharsets;
import java.nio.file.Files;
import java.nio.file.Paths;
import java.util.ArrayList;
import java.util.List;

public class Main {
   // private static List<Character> chars = new ArrayList<>();

    public static void main(String[] args) throws IOException {
      Files.lines(Paths.get("Z:\\result.txt"), StandardCharsets.UTF_8).forEach(System.out::println);
    }

}