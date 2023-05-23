using System;

namespace RefactorCodeForSolide
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Car //Singile respomnsibility maybe
    {
        private string makee = null;
        private string modell = null;

        public Car (string make, string model)
        {
            this.makee = make;
            this.modell = model;
            
        }

        public void StartEngine()
        {
            Console.WriteLine("Starting engine for " + this.makee + " " + this.modell);
        }

        public void StopEngine()
        {
            Console.WriteLine("Stopping engine for " + this.makee + " " + this.modell);
        }

        public void Drive()//bunu basqa methoda cixarmaq ola biler
        {
            Console.WriteLine("Driving " + this.makee + " " + this.modell);
        }
    }

    

    //Open-Closed and Single
    public class Rectangle:IShape, IDraw
    {
        public int Widthh { get; set; }
        public int Heightt { get; set; }

        public int CalculateArea()
        {
            return Widthh * Heightt;
        }

        public void Draw()
        {
            Console.WriteLine("Drawing rectangle with width " + Widthh + " and height " + Heightt);
        }

    }

    public interface IShape
    {
        public int CalculateArea();
    }

    public interface IDraw
    {
        public void Draw();
    }

    //public class Draw : IDraw
    //{
    //    public void Draw()
    //    {
    //        Console.WriteLine("Drawing rectangle with width " + base.Widthh+ " and height " + base.Heightt);
    //    }
    //}

    public class RectangleDrawer : IDrawer<Rectangle>
    {
        public void Draw(Rectangle shape)
        {
            Console.WriteLine("Drawing rectangle with width " + shape.Widthh + " and height " + shape.Heightt);
        }
    }

    public interface IDrawer<T> where T : IShape
    {
        void Draw(T shape);
    }



    //Liskov Substitution Principle
    public class Bird
    {
        public virtual void Fly()
        {
            Console.WriteLine("The bird is flying");
        }
    }

    public class Ostrich /*: Bird*/
    {
        //public override void Fly()
        //{
        //    throw new InvalidOperationException("Ostriches cannot fly");
        //}

        public Ostrich()
        {
            Console.WriteLine("The ostrich is not flying");
        }
    }

    //Interface Segregation + Liskov
    public interface IBird
    {
        void Fly();
    }

    public interface IFish
    {
        void Swim();
    }
    public interface IAnimal
    {
        void Eat();
        void Sleep();
    }
    public class BirdT2 : IBird, IAnimal
    {
        public void Eat()
        {
            Console.WriteLine("The bird is eating");
        }

        public void Sleep()
        {
            Console.WriteLine("The bird is sleeping");
        }

        public void Fly()
        {
            Console.WriteLine("The bird is flying");
        }
    }

    public class Fish : IFish, IAnimal
    {
        public void Eat()
        {
            Console.WriteLine("The fish is eating");
        }

        public void Sleep()
        {
            Console.WriteLine("The fish is sleeping");
        }

        public void Swim()
        {
            Console.WriteLine("The fish is swimming");
        }
    }

    //Dependency Inversion 
    public class LightBulb
    {
        public void TurnOn()
        {
            Console.WriteLine("The light bulb is on");
        }

        public void TurnOff()
        {
            Console.WriteLine("The light bulb is off");
        }
    }

    public class LightSwitch
    {
        LightBulb lig;
        public LightSwitch(LightBulb lig)
        {
            this.lig = lig;
        }

        public void TurnOn()
        {
            //base.TurnOn();
            lig.TurnOn();
            Console.WriteLine("The light bulb is on");
        }

        public void TurnOff()
        {
            //base.TurnOff();
            lig.TurnOff();
            Console.WriteLine("The light bulb is off");
        }
    }

}
