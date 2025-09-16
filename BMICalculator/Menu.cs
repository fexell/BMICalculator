using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculator {
    internal class Menu {
        public static Dictionary<int, MenuItem> MenuItems = new() {
            { 1, new MenuItem( "Calculate BMI", Program.Run ) },
            { 0, new MenuItem( "Exit", () => Environment.Exit( 0 ) ) },
        };

        public static void ShowMenu() {
            foreach(( int index, MenuItem menuItem ) in MenuItems ) {
                Console.WriteLine( $"{index}. {menuItem.Name}" );
            }
        }

        public static void Run() {
            while( true ) {
                Console.Clear();

                ShowMenu();

                Console.Write( "> " );
                int input = Helpers.IntValidator( Console.ReadLine() );
                Console.WriteLine();

                if( MenuItems.ContainsKey( input ) ) {
                    MenuItems[ input ].Action();
                } else {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine( "Invalid input. Press any key to return..." );
                    Console.ResetColor();
                    Console.ReadKey();
                }

                Console.WriteLine();
            }
        }
    }

    internal class MenuItem {
        public string Name { get; set; }
        public Action Action { get; set; }

        public MenuItem( string name, Action action, bool autoReturn = true ) {
            Name = name;

            if ( autoReturn )
                Action = () => { action(); Console.WriteLine( "\nPress any key to return..." ); Console.ReadKey(); };
            else
                Action = action;
        }
    }
}
