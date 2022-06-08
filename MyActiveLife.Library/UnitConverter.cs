using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyActiveLife.Library
{
    public static class UnitConverter
    {
        public static double KMtoMiles(double km)
        {
            return km * 0.621371;
        }

        public static double MetersToMiles(double meters)
        {
            return meters * 0.000621371;
        }

        public static string MetersToFeetInches(double meters)
        {
            var inches = meters * 39.3701;
            var feet = (int)inches / 12;
            var inchPart = (int)inches % 12;

            return feet + "\"" + " " + inchPart + "'";
        }

        public static int MetersToFeet(double meters)
        {
            var inches = meters * 39.3701;
            var feet = (int)inches / 12;

            return feet;
        }

        public static double MetersPerSecondtoMilesPerHour(double mps)
        {
            return mps * 2.23694;
        }

        public static double KilogramsToPounds(double kg)
        {
            return kg * 2.20462;
        }
    }
}
