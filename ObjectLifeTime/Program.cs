//Console.WriteLine("Hello, OS");

namespace ObjectLifeTime
{
    class Program
    {
        static void Main(string[] args)
        {
            //Guebage collection is a feature of .net framwork runtime
            //which handle the memory management of an object

            //In c++ we need to manage the memory management like
            //cleanung the object allocation etc by ourself.
            //If we dont do that it may create memory leak or using a corrupted memory.
            
            //creating an object of memory address in ram by .net framework runtime
            Car myCar = new Car();
            Car myThirdCar = new Car("Ford", "Escape", 2005, "White");

            
            myCar.Make = "Ferrari";
            myCar.Model = "F40";
            myCar.Year = 1940;
            myCar.Color = "Red";
            

            Car myOtherCar;
            myOtherCar = myCar;

            Console.WriteLine("{0} {1} {2} {3}", 
                myOtherCar.Make, 
                myOtherCar.Model, 
                myOtherCar.Year, 
                myOtherCar.Color);

            myOtherCar.Model = "FXXK";
            myOtherCar.Year = 2015;

            Console.WriteLine("{0} {1} {2} {3}",
                myCar.Make,
                myCar.Model,
                myCar.Year,
                myCar.Color);

            Console.WriteLine("{0} {1} {2} {3}",
                myThirdCar.Make,
                myThirdCar.Model,
                myThirdCar.Year,
                myThirdCar.Color);

            /*
            myOtherCar = null;
            //Will throw NullReferenceException was unhandled
            Console.WriteLine("{0} {1} {2} {3}",
                myCar.Make,
                myCar.Model,
                myCar.Year,
                myCar.Color);
            */

            Car.MyStaticMethod();


        }

        class Car
        {
            /*
            private string make;

            public string GetMake()
            {
                return make;
            }

            public void SetMake(string value)
            {
                make = value;
            }
            */

            public string Make { get; set; }
            public string Model { get; set; }
            public int Year { get; set; }
            public string Color { get; set; }

            public Car()
            {
                Make = "Nissan";
            }

            public Car(string make, string model, int year, string color)
            {
                Make = make;
                Model = model;
                Year = year;
                Color = color;
            }

            public static void MyStaticMethod()
            {
                Console.WriteLine("Called the static Method");
            }
        }
    }
}