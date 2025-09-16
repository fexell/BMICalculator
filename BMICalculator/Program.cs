

namespace BMICalculator {
    internal class Program {
        static double CalculateBMI( double weight, double height, string unit = "metric" ) {
            if( unit == "metric" )
                return weight / ( height * height );

            else if( unit == "imperial" )
                return 703 * weight / ( height * height );

            else {
                Console.WriteLine( "Invalid unit, returning 0." );
                return 0;
            }
        }

        static void Main(string[] args) {

        }
    }
}