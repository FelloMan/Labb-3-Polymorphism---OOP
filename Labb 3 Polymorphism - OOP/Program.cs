namespace Labb_3_Polymorphism___OOP
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            List<Geometry> shapes = new List<Geometry>
            {   // Main-metoden behöver inte veta exakt vilken typ varje objekt är (t.ex. Rectangle, Square, eller Circle). 
                // Varje objekt i listan använder sin egen version av Area() och Name, även om de alla hanteras som Geometry-objekt.
                // Detta tillåter att olika former kan hanteras på ett enhetligt sätt i koden, samtidigt som de behåller sitt unika beteende.
                // Polymorfism är som en formskiftare. Även om "Rectangle" verkar vara ett vanligt Geometry-objekt, skiftar den form när det är dags att agera - 
                // Vid anrop av Area() visar den sig och utför beräkningar specifika för rektanglar – multiplicerar sin bredd och höjd - 
                // Detta gör det möjligt för Rectangle att vara unik samtidigt som den kan hanteras som en del av en större grupp av Geometry-objekt.
                // Nya subklasser kan enkelt läggas till utan att ändra existerande kod, så länge de följer den definierade strukturen från basklassen eller gränssnittet
                new Rectangle(4, 5), //Här anger vi objektens dimensioner
                new Square(3),
                new Circle(4)
            };

            foreach (Geometry shape in shapes)
            {
                // Skriv ut namnet på formen tillsammans med dess area
                    Console.WriteLine($"Area of {shape.Name}: {shape.Area()}");
            }
            Console.ReadKey();
        }
    }



    public abstract class Geometry
    {
        // Abstrakt metod för att beräkna area, som ska implementeras i varje subklass
        public abstract double Area();

        // Abstrakt egenskap för namnet på formen
        public abstract string Name { get; }
    }

    public class Rectangle : Geometry
    {
        public double Width { get; set; }
        public double Height { get; set; }

        // Konstruktor för att initiera bredd och höjd för rektangeln
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        // Implementerar Name-egenskapen som beskriver formen
        public override string Name => "Rectangle";

        public override double Area()
        {
            return Width * Height; // Area = bredd * höjd
        }
    }

    public class Square : Geometry
    {
        public double Side { get; set; }

        // Konstruktor för att initiera sidan för kvadraten
        public Square(double side)
        {
            Side = side;
        }

        // Implementerar Name-egenskapen som beskriver formen
        public override string Name => "Square";

        public override double Area()
        {
            return Side * Side; // Area = sida * sida
        }
    }

    public class Circle : Geometry
    {
        public double Radius { get; set; }

        // Konstruktor för att initiera radien för cirkeln
        public Circle(double radius)
        {
            Radius = radius;
        }

        // Implementerar Name-egenskapen som beskriver formen
        public override string Name => "Circle";

        public override double Area()
        {
            return Math.PI * Radius * Radius; 
        }
    }

     

}
