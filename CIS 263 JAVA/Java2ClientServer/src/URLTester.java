import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.net.MalformedURLException;
import java.net.URL;

public class URLTester {

    public static void main(String[] args) throws MalformedURLException, IOException {
        InputStream input = new URL("https://www.google.com/").openStream();
        BufferedReader reader = new BufferedReader(new InputStreamReader(input));
        StringBuilder out = new StringBuilder();
        String line;
        while ((line = reader.readLine()) != null) {
            out.append(line);
        }

        System.out.println(out.toString());   //Prints the string content read from input stream
        reader.close();
    }
}