namespace Mediator
{
    public class Mediator
    {
        private readonly PartnerA _a;
        private readonly PartnerB _b;

        public Mediator(PartnerA a, PartnerB b)
        {
            _a = a;

            _b = b;
        }


        public void AWin(decimal money)
        {
            _a.Money += money;

            _b.Money -= money;
        }

        public void BWin(decimal money)
        {
            _b.Money += money;

            _a.Money -= money;
        }
    }
}
