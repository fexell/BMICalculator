using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculator {
    internal class Helpers {
        public static double WeightValidator( string value, string unit = "metric" ) {
            while ( true ) {
                if ( unit == "metric" ) {
                    if ( double.TryParse( value, out var weight ) && weight > 40 && weight < 200 ) {
                        return weight;
                    } else {
                        Console.Write( "Please enter a valid weight (40 - 200): " );
                        value = Console.ReadLine();
                    }
                } else if( unit == "imperial" ) {
                    if ( double.TryParse( value, out var weight ) && weight > 88 && weight < 440 ) {
                        return weight;
                    } else {
                        Console.Write( "Please enter a valid weight (88 - 440): " );
                        value = Console.ReadLine();
                    }
                }
            }
        }

        public static double HeightValidator( string value ) {
            while ( true ) {
                if ( double.TryParse( value, out double height ) && height > 1.20 && height < 2.00 ) {
                    return height;
                } else {
                    Console.Write( "Please enter a valid height (1.20 - 2.00): " );
                    value = Console.ReadLine();
                }
            }
        }
    }
}
