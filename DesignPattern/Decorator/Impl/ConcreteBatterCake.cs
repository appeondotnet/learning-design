namespace Decorator
{
    public class ConcreteBatterCake : BatterCake
    {
        public override decimal Cost()
        {
            return 5;
        }

        public override string Description()
        {
            return "煎饼果子5元一个";
        }
    }
}
