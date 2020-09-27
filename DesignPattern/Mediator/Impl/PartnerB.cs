namespace Mediator
{
    public class PartnerB : CardPartner
    {
        public PartnerB(decimal money) : base(money)
        {

        }

        public override void ChangeMoney(decimal money, Mediator mediator)
        {
            mediator.BWin(money);
        }
    }
}
