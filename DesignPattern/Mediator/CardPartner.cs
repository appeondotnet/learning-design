namespace Mediator
{
    public abstract class CardPartner
    {
        public CardPartner(decimal money)
        {
            Money = money;
        }

        public decimal Money { get; set; }

        public abstract void ChangeMoney(decimal money, Mediator mediator);
    }
}
