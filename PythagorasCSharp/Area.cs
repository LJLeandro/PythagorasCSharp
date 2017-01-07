using System;

namespace LJLeandro.Pythagoras.Formulas
{
    public class Area
    {
        /* GLOSSARY : Square Area
	    * 	'length' equals length of side.
	    * 	'A' equals Area
	    * FORMULA
	    * 	Area = length * length 
	    * */
        public static double CalculateSquare(double length)
        {
            return Math.Pow(length, 2);
        }

        /* GLOSSARY : Rectangle Area
	    * 	'width' 
	    * 	'height'
	    * 	'Area'
	    * FORMULA
	    * 	Area = width * height
	    * */
        public static double CalculateRectangle(double width, double height)
        {
            return width * height;
        }

        /* GLOSSARY : Circle Area
	    * 	'radius'
	    * 	'PI' equals 3,14
	    * 	'Area'
	    * FORMULA:
	    * 	Area = PI * (radius * radius)
	    * */
        public static double CalculateCircle(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        /* GLOSSARY : Triangle Area
	    *	'height'
	    *	'baseTriangle'
	    * 	'Area'
	    * FORMULA:
	    * 	Area = (baseTriangle * height) / 2
	    * */
        public static double CalculateTriangle(double height, double baseTriangle)
        {
            return (baseTriangle * height) / 2;
        }

        /* GLOSSARY : Parallelogram Area
	    * 	'height'
	    * 	'baseParallelogram'
	    * 	'Area'
	    * FORMULA:
	    * 	Area = baseParallelogram * height
	    * */
        public static double CalculateParallelogram(double baseParallelogram, double height)
        {
            return baseParallelogram * height;
        }

        /* GLOSSARY
	    * 	'height'
	    * 	'majorParallelSide'
	    * 	'minorParallelSide'
	    * 	'Area'
	    * FORMULA:
	    * 	Area = ((majorParallelSide + minorParallelSide) / 2) * height
	    * */
        public static double calculateTrapezoidOrTrapezium(double height, double majorParallelSide, double minorParallelSide)
        {
            return ((majorParallelSide + minorParallelSide) / 2) * height;
        }
    }
}
