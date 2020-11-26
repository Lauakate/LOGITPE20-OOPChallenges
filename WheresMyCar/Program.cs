using System;

namespace WheresMyCar
{
    class Program
    {
        class Car
        {
            string name;
            string modelName;
            string regNum;
            string color;
            int odometer;
            int fueltank;

            public Car(string _name, string _modelName, string _regNum, string _color, int _odometer, int _fueltank)
            {
                name = _name;
                modelName = _modelName;
                regNum = _regNum;
                color = _color;
                odometer = 0;
                fueltank = 60;

            }

            public void Drive()
            {
                Console.WriteLine($"The {name} {modelName} passes a lap");

                odometer += 100;
                fueltank -= 5;
            }

            public double Odometer
            {
                get { return odometer; }
            }

            public double Fueltank
            {
                get { return fueltank; }
            }

            public void ShowCarData()
            {
                Console.WriteLine($"Name: {name}, Model name: {modelName}, Registration number: {regNum}, Color: {color}, Current odometer state: {odometer}, Current fueltank state: {fueltank}");
            }


        }

        static void Main(string[] args)
        {
            Car newCar = new Car("Toyota Celica", "XX 2800GT", "SOZ251", "Green", 0, 60);
            Console.WriteLine($"Odometer: {newCar.Odometer} Fueltank: {newCar.Fueltank}");

            while(newCar.Fueltank != 0)
            {
                newCar.Drive();

                Console.WriteLine($"Odometer: {newCar.Odometer} Fueltank: {newCar.Fueltank}");
            }


            Console.WriteLine($"The car has stopped! You ran out of fuel");

            newCar.ShowCarData();
        }
    }
}
