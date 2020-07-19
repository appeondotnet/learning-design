namespace Decorator
{
    public class ConcreteSauce : BatterCake
    {
        public override decimal Cost()
        {
            return 1;
        }

        public override string Description()
        {
            return "酱料1元一份";
        }
    }
}
