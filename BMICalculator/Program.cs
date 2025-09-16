

namespace BMICalculator {
    internal class Program {
        static double CalculateBMI( double weight, double height, string unit = "metric" ) {
            if( unit == "metric" )
                return weight / ( height * height );

            else if( unit == "imperial" ) {
                double weightInPounds = weight * 2.20462;
                double heightInInches = height * 39.3701;

                return 703 * ( weightInPounds / ( heightInInches * heightInInches ) );
            }

            else {
                Console.WriteLine( "Invalid unit, returning 0." );
                return 0;
            }
        }

        public static void Run() {
            Console.Write( "Enter your weight: " );
            double weight = Helpers.WeightValidator( Console.ReadLine() );
            Console.Write( "Enter your height: " );
            double height = Helpers.HeightValidator( Console.ReadLine() );

            double bmi1 = CalculateBMI( weight, height );
            Console.WriteLine( $"BMI (metric, default): {bmi1:F2}" );

            double bmi2 = CalculateBMI( height: height, weight: weight );
            Console.WriteLine( $"BMI (metric, named args): {bmi2:F2}" );

            double bmi3 = CalculateBMI( unit: "imperial", weight: weight, height: height );
            Console.WriteLine( $"BMI (imperial): {bmi3:F2}" );
        }

        static void Main(string[] args) {
            Menu.Run();
        }
    }
}