public class Logger {

    // Step 1: Create a private static instance
    private static Logger instance;

    // Step 2: Make the constructor private
    private Logger() {
        System.out.println("Logger Instance Created");
    }

    // Step 3: Provide a public static method to get the instance
    public static Logger getInstance() {
        if (instance == null) {
            instance = new Logger();
        }
        return instance;
    }

    // Sample logging method
    public void log(String message) {
        System.out.println("Log: " + message);
    }
}