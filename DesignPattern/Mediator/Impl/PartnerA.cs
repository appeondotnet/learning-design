namespace Mediator
{
    public class PartnerA : CardPartner
    {
        public PartnerA(decimal money) : base(money)
        {

        }

        public override void ChangeMoney(decimal money, Mediator mediator)
        {
            mediator.AWin(money);
        }
    }
}
