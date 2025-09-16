using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculator {
    internal class Helpers {
        public static int IntValidator( string value ) {
            while ( true ) {
                if ( int.TryParse( value, out int number ) ) {
                    return number;
                } else {
                    Console.Write( "Please enter a valid number: " );
                    value = Console.ReadLine();
                }
            }
        }

        public static double DoubleValidator( string value ) {
            while ( true ) {
                if ( double.TryParse( value, out double number ) ) {
                    return number;
                } else {
                    Console.Write( "Please enter a valid (double) number: " );
                    value = Console.ReadLine();
                }
            }
        }

        public static double WeightValidator( string value ) {
            while ( true ) {
                if ( double.TryParse( value, out double weight ) && weight > 20 && weight < 300 ) {
                    return weight;
                } else {
                    Console.Write( "Please enter a valid weight (20 - 300): " );
                    value = Console.ReadLine();
                }
            }
        }

        public static double HeightValidator( string value ) {
            while ( true ) {
                value = value.Replace( '.', ',' );

                if( double.TryParse( value, out double height ) && height > 1.20 && height < 2.00 ) {
                    return height;
                } else {
                    Console.Write( "Please enter a valid height (1.20 - 2.00): " );
                    value = Console.ReadLine();
                }
            }
        }
    }
}
