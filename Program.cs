namespace Cars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.vin = "2FMDA5146TBC22506";
            car1.make = "Ford";
            car1.model = "Fiesta";
            car1.mileage = 25400;
            car1.Drive(1000);
            car1.Display();

            Console.WriteLine();

            Car car2 = new Car();
            car2.vin = "JH4KA4660LC006262";
            car2.make = "Cadillac";
            car2.model = "Escalade";
            car2.mileage = 400;
            car2.Drive(100);
            car2.Display();

        }
    }
    public class Car
    {
        private string _vin;
        public string vin {
        
            get { return _vin; }
            set { _vin = value; }
        }
        private string _make;
        public string make
        {
            get { return _make; }
            set { _make = value; }
        }

        private string _model;
        public string model
        {
            get { return _model; }
            set { _model = value; }
        }
        private int _mileage;
        public int mileage
        {
            get { return _mileage; }
            set { _mileage = value; }
        }
        public Car()
        {
            vin = "";
            make = "";
            model = "";
            mileage = 0;
        }
        public Car(string vin, string make, string model, int mileage)
        {
            this.vin = vin;
            this.make = make;
            this.model = model;
            this.mileage = mileage;
        }
        public void Drive(int miles)
        {
            if (miles > 0)
            {
                mileage +=miles;
            }
        }
        public void Display()
        {
            Console.WriteLine($"VIN: {vin}");
            Console.WriteLine($"Make: {make}");
            Console.WriteLine($"Model: {model}");
            Console.WriteLine($"Mileage: {mileage}");
        }

    }
}
