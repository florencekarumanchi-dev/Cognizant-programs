public class FinancialForecast {

    // Recursive method to calculate future value
    public double calculateFutureValue(double currentValue, double growthRate, int years) {

        // Base case
        if (years == 0) {
            return currentValue;
        }

        // Recursive call
        return calculateFutureValue(currentValue, growthRate, years - 1) * (1 + growthRate);
    }
}