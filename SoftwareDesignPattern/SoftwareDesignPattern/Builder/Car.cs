namespace SoftwareDesignPattern.Builder
{
    public class Car
    {
        /*
         Builder pattern
         Has many optional parameters
         0bject creation process is complex
         Make the code more readable and maintainable
         */

        public string Brand { get; private set; }
        public string Model { get; private set; }
        public int Year { get; private set; }
        public string Engine { get; private set; }
        public string Color { get; private set; }
        public bool HasSunroof { get; private set; }
        public bool HasGPS { get; private set; }
        public bool HasLeatherSeats { get; private set; }

        private Car() { } // Private constructor to force using Builder

        public override string ToString()
        {
            return $"{Brand} {Model} ({Year}) - {Engine}, Color: {Color}, Sunroof: {HasSunroof}, GPS: {HasGPS}, Leather Seats: {HasLeatherSeats}";
        }

        // 🔹 Inner Builder Class
        public class Builder
        {
            private Car _car = new Car();

            public Builder SetBrand(string brand)
            {
                _car.Brand = brand;
                return this;
            }

            public Builder SetModel(string model)
            {
                _car.Model = model;
                return this;
            }

            public Builder SetYear(int year)
            {
                _car.Year = year;
                return this;
            }

            public Builder SetEngine(string engine)
            {
                _car.Engine = engine;
                return this;
            }

            public Builder SetColor(string color)
            {
                _car.Color = color;
                return this;
            }

            public Builder AddSunroof()
            {
                _car.HasSunroof = true;
                return this;
            }

            public Builder AddGPS()
            {
                _car.HasGPS = true;
                return this;
            }

            public Builder AddLeatherSeats()
            {
                _car.HasLeatherSeats = true;
                return this;
            }

            public Car Build()
            {
                return _car;
            }
        }
    }

}
