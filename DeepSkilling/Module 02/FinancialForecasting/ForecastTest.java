public class ForecastTest {

    public static void main(String[] args) {

        double currentValue = 10000.0;
        double growthRate = 0.10;   // 10%
        int years = 5;

        FinancialForecast forecast = new FinancialForecast();

        double futureValue = forecast.calculateFutureValue(currentValue, growthRate, years);

        System.out.println("Current Value : " + currentValue);
        System.out.println("Growth Rate   : " + (growthRate * 100) + "%");
        System.out.println("Years         : " + years);
        System.out.println("Future Value  : " + futureValue);
    }
}