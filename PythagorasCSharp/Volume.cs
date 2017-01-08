using System;

namespace LJLeandro.Pythagoras.Formulas
{
    public class Volume
    {
        /* GLOSSARY : Cube Volume
	    * 	'length'
	    * FORMULA
	    * 	Volume = length * length * length
	    * */
        public static double CalculateCubeVolume(double length)
        {
            return Math.Pow(length, 3);
        }

        /* GLOSSARY : Rectangular Solid Volume
	    * 	'length'
        * 	'width'
        * 	'height'
	    * FORMULA
	    * 	Volume = length * width * height
	    * */
        public static double CalculateRectangularSolidVolume(double length, double width, double height)
        {
            return length * width * height;
        }

        /* GLOSSARY : Rectangular Solid Volume
        * 	'radius'
        * 	'width'
        * 	'pi' equals 3,14
        * FORMULA
        * 	Volume = pi * (radius * radius) * height
        * */
        public static double CalculateCylinderVolume(double height, double radius)
        {
            return Math.PI * Math.Pow(radius, 2) * height;
        }

        /* GLOSSARY : Sphere Volume
        * 	'radius'
        * 	'pi' equals 3,14
        * FORMULA
        * 	Volume = (4 * pi * (radius * radius * radius)) / 3
        * */
        public static double CalculateSphereVolume(double radius)
        {
            return (4 * Math.PI * (Math.Pow(radius, 3))) / 3;
        }

        /* GLOSSARY : Cone Volume
        * 	'radius'
        * 	'pi' equals 3,14
        * 	'height'
        * FORMULA
        * 	Volume = (pi * (radius * radius) * height) / 3
        * */
        public static double CalculateConeVolume(double radius, double height)
        {
            return (Math.PI * (Math.Pow(radius, 2) * height)) / 3;
        }

        /* GLOSSARY : Cone Volume
        * 	'pyramidBase'
        * 	'height'
        * FORMULA
        * 	Volume = (pyramidBase * height) / 3
        * */
        public static double CalculatePyramidVolume(double pyramidBase, double height)
        {
            return (pyramidBase * height) / 3;
        }
    }
}
