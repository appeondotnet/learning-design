namespace Proxy
{
    public class Proxy : IMath
    {
        private readonly ConcreteMath _math;

        public Proxy()
        {
            _math = new ConcreteMath();
        }

        public double Add(double x, double y)
        {
            return _math.Add(x, y);
        }

        public double Subtract(double x, double y)
        {
            return _math.Subtract(x, y);
        }

        public double Multiply(double x, double y)
        {
            return _math.Multiply(x, y);
        }

        public double Divide(double x, double y)
        {
            return _math.Divide(x, y);
        }
    }
}
